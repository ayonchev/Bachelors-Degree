using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using ShipCrash.UI.Entities.DefensiveUnits.Bullets;
using ShipCrash.UI.Entities.Enemies;
using ShipCrash.UI.Entities.Interfaces;
using ShipCrash.UI.Managers;

namespace ShipCrash.UI.Entities.DefensiveUnits
{
    public abstract class DefensiveUnit : BaseEntity, IBuyable
    {
        private const int DEFAULT_WIDTH = 70;
        private const int DEFAULT_RANGE = 50;
        private const double DEFAULT_SHOOTING_INTERVAL = 1000;
        public DefensiveUnit(int price, /*List<Enemy> enemies,*/ Uri imageURI, int width = DEFAULT_WIDTH) : 
            base(imageURI, width)
        {
            Price = price;
            Range = DEFAULT_RANGE;
            ShootingInterval = DEFAULT_SHOOTING_INTERVAL;
            Bullets = new List<Bullet>();
            Timer = new DispatcherTimer();
        }

        public void Initialize(List<Enemy> enemies)
        {
            Enemies = enemies;
            RangeRect = new Rect(
                this.Rect.X - DEFAULT_RANGE,
                this.Rect.Y - DEFAULT_RANGE,
                this.Rect.Width + DEFAULT_RANGE * 2,
                this.Rect.Height + DEFAULT_RANGE * 2
            );

            Timer.Interval = TimeSpan.FromMilliseconds(ShootingInterval);
            Timer.Tick += IsEnemyInRange;
            Timer.Start();
        }

        public event EventHandler<Enemy> EnemyKilled;
        public int Price { get; protected set; }
        public double ShootingInterval { get; protected set; }
        public double Range { get; protected set; }
        public DispatcherTimer Timer { get; private set; }
        public Rect RangeRect { get; private set; }
        public List<Enemy> Enemies { get; protected set; }
        public Enemy CurrentTarget { get; protected set; }
        public List<Bullet> Bullets { get; protected set; }
        public void IsEnemyInRange(object sender, EventArgs args)
        {
            if (CurrentTarget == null)
            {
                CurrentTarget = Enemies.FirstOrDefault(e => e.Rect.IntersectsWith(RangeRect));

                if (CurrentTarget != null)
                {
                    Trace.WriteLine("Enemy in range.");
                    OnShoot(null, null);
                }
            }
            else if(CurrentTarget.Rect.IntersectsWith(RangeRect))
            {
                OnShoot(null, null);
            }
            else
            {
                CurrentTarget = null;
            }
        }

        protected abstract void OnShoot(object sender, EventArgs e);

        protected void Shoot(Bullet bullet)
        {
            Trace.WriteLine("Shoot veeee");
            Bullets.Add(bullet);
            bullet.MovementCompleted += OnBulletReachedTarget;
            // TODO : move the point initialization into the base entity ( use the GetCoordinates method in the GameManager )
            //double objectCenterX = Canvas.GetLeft(CurrentTarget.Control) + CurrentTarget.Control.ActualWidth / 2;
            //double objectCenterY = Canvas.GetTop(CurrentTarget.Control) + CurrentTarget.Control.ActualHeight / 2;

            bullet.SetCoordinates(this.Coordinates);
            Trace.WriteLine($"Bullet starts to shoot towards {CurrentTarget.Coordinates}.");
            bullet.Start(CurrentTarget.Coordinates);
        }

        private void OnBulletReachedTarget(object sender, Enemy targetEnemy)
        {
            Trace.WriteLine("Bullet completed.");
            Bullet bullet = sender as Bullet;
            Bullets.Remove(bullet);

            if (targetEnemy != null || Bullets.Count == 0)
            {
                CurrentTarget = null;
                if (targetEnemy != null && EnemyKilled != null)
                    EnemyKilled.Invoke(this, targetEnemy);
            }
        }

        protected override void Destroy()
        {
            Trace.WriteLine("Tower destroyed!");
            Bullets.ForEach(b => b.RemoveAnimation());
            Timer.Tick -= IsEnemyInRange;
            EnemyKilled = null;
            Timer.Stop();
            Timer = null;
            base.Destroy();
        }
    }
}
