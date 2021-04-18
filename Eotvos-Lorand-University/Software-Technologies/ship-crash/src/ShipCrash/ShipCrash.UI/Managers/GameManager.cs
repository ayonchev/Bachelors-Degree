using ShipCrash.UI.Entities;
using ShipCrash.UI.Entities.Enemies;
using ShipCrash.UI.Entities.Enums;
using ShipCrash.UI.Entities.DefensiveUnits;
using ShipCrash.UI.Managers.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using ShipCrash.UI.Managers.Enums;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace ShipCrash.UI.Managers
{
    public class GameManager : IGameManager, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private Canvas gameField;
        private Island island;
        private int experiencePoints;
        private GameState gameState;
        private List<Enemy> enemies;
        private List<DefensiveUnit> defensiveUnits;
        private DefensiveUnit newDefensiveUnit;
        private DispatcherTimer timer;
        private double interval = 8000;
        private int xpThreshold = 100;

        public int LifePoints => this.island.LifePoints;
        public int ExperiencePoints 
        { 
            get
            {
                return experiencePoints;
            }
            private set
            {
                experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }
        public BuyManager BuyManager { get; private set; }
        public GameState GameState 
        { 
            get
            {
                return gameState;
            }
            private set
            {
                gameState = value;
                OnPropertyChanged("GameState");
            } 

        }
        public List<Enemy> Enemies => enemies;
        public GameManager(Canvas gameField)
        {
            this.gameField = gameField;
            enemies = new List<Enemy>();
            defensiveUnits = new List<DefensiveUnit>();
            Initialize();
        }

        public void Initialize()
        {
            BaseEntity.EntityAdded = OnAdded;
            BaseEntity.EntityDestroyed = OnDestroyed;
            CreateIsland();

            Enemy.MainTarget = island;

            BuyManager = new BuyManager(OnUnitPurchased);
            ExperiencePoints = 0;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(interval);
            timer.Tick += AddEnemy;

            GameState = GameState.NotRunning;
        }

        private void TowersCountChanged(object sender, EventArgs e)
        {
            if(LifePoints == 0)
            {
                Stop();
            }
            OnPropertyChanged("LifePoints");
        }

        private void CreateIsland()
        {
            this.island = new Island();
            double positionX = gameField.Width / 2 - (island.Control.Source.Width / 2);
            double positionY = gameField.Height / 2 - (island.Control.Source.Height / 2);
            island.SetCoordinates(new Point(positionX, positionY));
            island.LifePointsChanged += TowersCountChanged;
            island.CreateTowers();
        }

        private void OnUnitPurchased(DefensiveUnit newDefensiveUnit)
        {
            MessageBox.Show($"Place the new {newDefensiveUnit.GetType().Name} anywhere on the field");
            this.newDefensiveUnit = newDefensiveUnit;
        }

        //TODO: Put in enemy manager.
        private void AddEnemy(object sender, EventArgs e)
        {
            // TODO : Maybe put all the code related to the enemy in an enemy manager and put the movement functionality in a static movement manager.
            Enemy enemy = CreateEnemy();
            Point coordinates = GetTargetCoordinates(island.Control);
            enemy.Start(coordinates);
        }

        private Point GetTargetCoordinates(Image control)
        {
            double objectCenterX = Canvas.GetLeft(control) + control.ActualWidth / 2;
            double objectCenterY = Canvas.GetTop(island.Control) + island.Control.ActualHeight / 2;
            return new Point(objectCenterX, objectCenterY);
        }

        public void Start()
        {
            this.GameState = GameState.Running;
            timer.Start();
        }

        public void Pause()
        {
            if (this.GameState == GameState.Running)
            {
                this.GameState = GameState.Paused;
                this.timer.Stop();
                // TODO : Pause the movement of each entity
                enemies.ForEach(e => e.Pause());
                defensiveUnits.ForEach(du =>
                {
                    du.Timer.Stop();
                    du.Bullets.ForEach(b => b.Pause());
                });
            }
        }

        public void Restart()
        {
            experiencePoints = 0;
            BuyManager.ResetMoney();
            foreach (var entity in defensiveUnits)
            {
                gameField.Children.Remove(entity.Control);
            }
            foreach (var entity in enemies)
            {
                gameField.Children.Remove(entity.Control);
            }
            foreach (var islandTower in island.Towers)
            {
                gameField.Children.Remove(islandTower.Control);
            }

            gameField.Children.Remove(island.Control);
            CreateIsland();
            Enemy.MainTarget = island;
        }

        public void Resume()
        {
            //TODO : Introduce a state manager which deals with the state of the application, because right now if we haven't started the application but we buy and place a unit, the game will start automatically.
            if (this.GameState == GameState.Paused)
            {
                this.GameState = GameState.Running;
                this.timer.Start();
                enemies.ForEach(e => e.Resume());
                defensiveUnits.ForEach(du =>
                {
                    du.Timer.Start();
                    du.Bullets.ForEach(b => b.Resume());
                });
            }
        }

        //TODO: Introduce different functions for the different entities.
        public void OnAdded(BaseEntity entity, Point coordinates)
        {
            Canvas.SetLeft(entity.Control, coordinates.X);
            Canvas.SetTop(entity.Control, coordinates.Y);

            gameField.Children.Add(entity.Control);
        }

        public void OnDestroyed(BaseEntity entity)
        {
            gameField.Children.Remove(entity.Control);

            if (entity is Enemy)
            {
                enemies.Remove(entity as Enemy);
            }
            else if (entity is DefensiveUnit)
            {
                defensiveUnits.Remove(entity as DefensiveUnit);
            }
        }

        private void UpdateExperiencePoints(int amount)
        {
            this.ExperiencePoints += amount;

            if(ExperiencePoints >= xpThreshold)
            {
                xpThreshold *= 2;
                interval /= 2;
            }
        }

        private void OnEnemyKilled(object sender, Enemy enemy)
        {
            Trace.WriteLine($"{enemy.GetType().Name} killed");
            UpdateExperiencePoints(enemy.AttackPoints);
            this.BuyManager.UpdateMoney(enemy.AttackPoints);
        }

        //TODO: Put in defensive unit manager.
        public void AddDefensiveUnit(Point position)
        {
            if (newDefensiveUnit == null)
                return;

            double startXCalculation = position.X - (newDefensiveUnit.Control.Source.Width / 2);
            if (startXCalculation < 0)
                startXCalculation = 0;
            else if (startXCalculation + newDefensiveUnit.Control.Source.Width > gameField.Width)
                startXCalculation = gameField.Width - newDefensiveUnit.Control.Source.Width;

            double startYCalculation = position.Y - (newDefensiveUnit.Control.Source.Height / 2);
            if (startYCalculation < 0)
                startYCalculation = 0;
            else if (startYCalculation + newDefensiveUnit.Control.Source.Height > gameField.Height)
                startYCalculation = gameField.Height - newDefensiveUnit.Control.Source.Height;

            newDefensiveUnit.SetCoordinates(new Point(startXCalculation, startYCalculation));

            this.defensiveUnits.Add(newDefensiveUnit);
            newDefensiveUnit.Initialize(enemies);
            newDefensiveUnit.EnemyKilled += OnEnemyKilled;
            newDefensiveUnit = null;

            this.Resume();
        }

        //TODO: Put in enemy manager.
        public Enemy CreateEnemy()
        {
            Random rnd = new Random();
            Directions selectedDirection = (Directions)rnd.Next(0, 4);

            int startX = 0;
            int startY = 0;
            int canvasWidth = (int)Math.Round(gameField.Width);
            int canvasHeight = (int)Math.Round(gameField.Height);

            switch (selectedDirection)
            {
                case Directions.Left:
                    startY = rnd.Next(0, canvasHeight - 50);
                    break;
                case Directions.Right:
                    startX = canvasWidth - 50;
                    startY = rnd.Next(50, canvasHeight - 50);
                    break;
                case Directions.Up:
                    startX = rnd.Next(50, canvasWidth - 50);
                    break;
                case Directions.Down:
                    startY = canvasHeight - 100;
                    startX = rnd.Next(0, canvasWidth - 50);
                    break;
            }
            Enemy enemy = new BasicEnemy(defensiveUnits);
            enemy.SetCoordinates(new Point(startX, startY));

            enemies.Add(enemy);

            return enemy;
        }

        public void Stop()
        {
            this.timer.Tick -= AddEnemy;
            this.timer = null;
            GameState = GameState.Over;
        }
    }
}
