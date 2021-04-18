using ShipCrash.UI.Entities.DefensiveUnits;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ShipCrash.UI.Managers
{
    public class BuyManager
    {
        private Action<DefensiveUnit> unitPurchased;

        private const int DEFAULT_MONEY = 40;
        private const string moneyTextFormat = "Money: {0}$";
        private const string buyButtonNameEnding = "BuyButton";
        private const string buyButtonNameFormat = "{0}_{1}";
        private Grid buyMenuGrid;
        public int Money { get; private set; }
        public DefensiveUnit[] BuyableObjects { get; private set; }
        public Grid BuyMenuGrid 
        { 
            get
            {
                UpdateDynamicControls();
                return this.buyMenuGrid;
            }
            private set
            {
                this.buyMenuGrid = value;
            }
        }
        public TextBlock MoneyTextBlock { get; private set; }
        public Button[] BuyButtons { get; private set; }

        public BuyManager(
            Action<DefensiveUnit> unitPurchasedEventHandler,
            int startMoney = DEFAULT_MONEY)
        {
            Money = startMoney;
            unitPurchased = unitPurchasedEventHandler;
        }
        public void Initialize(RoutedEventHandler handler)
        {
            MoneyTextBlock = new TextBlock();
            BuyableObjects = GetBuyableObjects();
            BuyButtons = new Button[BuyableObjects.Length];
            BuyMenuGrid = CreateBuyMenuGrid(handler);
        }
        public Grid CreateBuyMenuGrid(RoutedEventHandler handler)
        {
            Grid grid = new Grid();

            for (int i = 0; i < BuyableObjects.Length; i++)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();
                columnDefinition.Width = new GridLength(1, GridUnitType.Star);
                RowDefinition firstRowDefinition = new RowDefinition();
                firstRowDefinition.Height = new GridLength(1, GridUnitType.Star);
                RowDefinition secondRowDefinition = new RowDefinition();
                secondRowDefinition.Height = new GridLength(1, GridUnitType.Star);

                grid.ColumnDefinitions.Add(columnDefinition);
                grid.RowDefinitions.Add(firstRowDefinition);
                grid.RowDefinitions.Add(secondRowDefinition);
            }

            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });

            MoneyTextBlock.FontWeight = FontWeights.Bold;
            MoneyTextBlock.FontSize = 20;
            MoneyTextBlock.Padding = new Thickness(10, 0, 0, 0);
            Grid.SetColumn(MoneyTextBlock, 0);
            Grid.SetRow(MoneyTextBlock, 0);
            grid.Children.Add(MoneyTextBlock);

            for (int i = 0; i < BuyableObjects.Length; i++)
            {
                var buyableObject = BuyableObjects[i];

                TextBlock details = new TextBlock();
                details.Text = "Details: " + Environment.NewLine + 
                              $"{buyableObject.GetType().Name}" + Environment.NewLine;
                details.TextAlignment = TextAlignment.Center;

                Button buyObjectButton = new Button();
                buyObjectButton.Content = $"Buy ${buyableObject.Price}";
                buyObjectButton.Name =
                    string.Format(buyButtonNameFormat, buyableObject.GetType().Name, buyButtonNameEnding);
                buyObjectButton.Click += handler;
                BuyButtons[i] = buyObjectButton;

                buyObjectButton.IsEnabled = Money >= buyableObject.Price;

                Grid.SetColumn(buyableObject.Control, i);
                Grid.SetRow(buyableObject.Control, 1);
                Grid.SetColumn(details, i);
                Grid.SetRow(details, 2);
                Grid.SetColumn(buyObjectButton, i);
                Grid.SetRow(buyObjectButton, 3);
                grid.Children.Add(buyableObject.Control);
                grid.Children.Add(details);
                grid.Children.Add(buyObjectButton);
            }

            return grid;
        }

        public void ResetMoney()
        {
            Money = DEFAULT_MONEY;
        }
        public void UpdateMoney(int newMoney)
        {
            Money += newMoney;
        }
        public void BuyDefensiveUnit(string name)
        {
            name = name.Split('_')[0];
            Type type = typeof(DefensiveUnit).Assembly.GetTypes()
                .FirstOrDefault(t => t.IsSubclassOf(typeof(DefensiveUnit)) && !t.IsAbstract && t.Name == name);
            DefensiveUnit instance = (DefensiveUnit)Activator.CreateInstance(type);

            if (Money < instance.Price)
                throw new InvalidOperationException("You don't have enough money!");

            Money -= instance.Price;

            this.unitPurchased(instance);
        }
        private DefensiveUnit[] GetBuyableObjects()
        {
            // TODO : Research why the entities are not created with the given width.
            IEnumerable<DefensiveUnit> buyableObjects = typeof(DefensiveUnit)
                .Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(DefensiveUnit)) && !t.IsAbstract)
                .Select(t => (DefensiveUnit)Activator.CreateInstance(t, 240));
            return buyableObjects.ToArray();
        }
        private void UpdateDynamicControls()
        {
            for (int i = 0; i < BuyButtons.Length; i++)
            {
                Button button = BuyButtons[i];
                button.IsEnabled = Money >= BuyableObjects[i].Price;
            }

            MoneyTextBlock.Text = string.Format(moneyTextFormat, Money);
        }
    }
}
