namespace ClothingShop.Core
{
    using ClothingShop.Entities;
    using ClothingShop.Entities.Contracts;
    using ClothingShop.Entities.Products;
    using ClothingShop.Entities.Factories;
    using ClothingShop.Entities.Products.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;
    using ClothingShop.Core.Contracts;

    public class Engine : IEngine
    {
        private IInventory inventory;
        private ProductFactory factory;

        public Engine(IInventory inventory)
        {
            this.inventory = inventory;
            this.factory = new ProductFactory();
        }

        public void Run()
        {
            ApplicationStart();

            while (true)
            {
                var currentCommand = Console.ReadLine();

                if (currentCommand == "Exit")
                {
                    break;
                }

                try
                {
                    var result = ProcessCommand(currentCommand);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ApplicationStart()
        {
            Console.WriteLine("Hello, dear user into my Clothes Shop!" + Environment.NewLine);
            Console.WriteLine("Here is a list of products that we have in our shop: ");

            var types = Assembly.GetCallingAssembly().GetTypes();
            foreach (var currentType in types.Where(t => !t.IsInterface && t.BaseType.Name == typeof(Product).Name))
            {
                Console.Write(currentType.Name + '\t');
            }

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "And here is a list of commands that you can execute");
            var counter = 1;
            foreach (var currentMethod in inventory.GetType().GetMethods().Where(m => m.IsFinal))
            {
                Console.WriteLine(counter++ + ". " + currentMethod.Name);
            }
            Console.WriteLine(counter++ + ". " + "Exit" + Environment.NewLine);

            Console.WriteLine("You can create new products by specifying their price, size, manufacturer, or by creating a default one. Execute each command by typing its number and for example the type of product that you want to add like - \'1, Shirt, 30, M, Teodor\'" + Environment.NewLine);

            Console.WriteLine("The sizes available are: ");
            foreach (var value in typeof(Size).GetEnumValues())
            {
                Console.Write(value.ToString() + '\t');
            }

            Console.WriteLine(Environment.NewLine  + Environment.NewLine + "Okay, let's start!");
        }

        private string ProcessCommand(string currentCommandData)
        {
            var currentCommandArgs = currentCommandData.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var currentCommand = currentCommandArgs[0];
            string productType = string.Empty;
            string result = string.Empty;

            switch (currentCommand)
            {
                case "1":
                    IProduct currentProduct;
                    productType = currentCommandArgs[1];
                    if (currentCommandArgs.Length > 2)
                    {
                        var currentPrice = double.Parse(currentCommandArgs[2]);
                        var currentSize = (Size)Enum.Parse(typeof(Size), currentCommandArgs[3]);
                        var currentManufacturer = currentCommandArgs.Skip(4).ToString();

                        currentProduct = factory.CreateProduct(productType, currentPrice, currentSize, currentManufacturer);
                    }
                    else
                    {
                        currentProduct = factory.CreateProduct(productType);
                    }

                    inventory.AddProductToInventory(currentProduct);
                    result = $"Succesfully added the {productType}!";
                    break;

                case "2":
                    productType = currentCommandArgs[1];
                    int value = int.Parse(currentCommandArgs[2]);

                    inventory.AddStockOnProduct(value, productType);
                    result = $"Succesfully added {value} products of type {productType} to the inventory!";
                    break;

                case "3":
                    productType = currentCommandArgs[1];
                    var productValue = inventory.CalculateTotalProductValue(productType);

                    result = $"The total value of products of type {productType} is {productValue}$.";
                    break;

                case "4":
                    var inventoryValue = inventory.CalculateTotalInventoryValue();

                    result = $"The total value of the inventory is {inventoryValue}$.";
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    throw new InvalidOperationException("There is no such command!");
            }

            return result;
        }
    }
}
