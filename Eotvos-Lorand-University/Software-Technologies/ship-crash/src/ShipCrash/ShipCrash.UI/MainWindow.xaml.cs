using ShipCrash.UI.Managers;
using ShipCrash.UI.Managers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShipCrash.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IGameManager gameManager;
        BuyWindow buyWindow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gameManager = new GameManager(gameField);
            this.DataContext = gameManager;
            buyWindow = new BuyWindow(gameManager.BuyManager);
            buyWindow.Closing += BuyWindow_Closing;
        }

        private void PlaceAttackingTower(object sender, MouseEventArgs e)
        {
            Point position = e.GetPosition(gameField);
            gameManager.AddDefensiveUnit(position);
        }

        private void AddEnemy(object sender, RoutedEventArgs e)
        {
            gameManager.CreateEnemy();
        }

        private void StartButtonClicked(object sender, RoutedEventArgs e)
        {
            gameManager.Start();
        }

        private void PauseButtonClicked(object sender, RoutedEventArgs e)
        {
            gameManager.Pause();
        }
        private void ResumeButtonClicked(object sender, RoutedEventArgs e)
        {
            gameManager.Resume();
        }

        private void RestartButtonClicked(object sender, RoutedEventArgs e)
        {
            gameManager.Restart();
        }

        private void BuyButtonClicked(object sender, RoutedEventArgs e)
        {
            gameManager.Pause();
            buyWindow.Visibility = Visibility.Visible;
        }

        private void BuyWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gameManager.Resume();
        }
    }
}
