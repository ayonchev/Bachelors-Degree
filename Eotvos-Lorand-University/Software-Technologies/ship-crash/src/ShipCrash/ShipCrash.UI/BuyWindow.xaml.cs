using ShipCrash.UI.Managers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShipCrash.UI
{
    /// <summary>
    /// Interaction logic for BuyWindow.xaml
    /// </summary>
    public partial class BuyWindow : Window
    {
        BuyManager buyManager;
        public BuyWindow(BuyManager buyManager)
        {
            InitializeComponent();
            this.buyManager = buyManager;
            this.buyManager.Initialize(BuyObjectButtonClicked);
            this.IsVisibleChanged += VisibilityChanged;
            this.Closing += BuyWindow_Closing;
        }

        private void BuyWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Visibility = Visibility.Hidden;
        }

        private void VisibilityChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                Content = buyManager.BuyMenuGrid;
        }

        public void BuyObjectButtonClicked(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;

            Button button = sender as Button;
            buyManager.BuyDefensiveUnit(button.Name);
        }
    }
}
