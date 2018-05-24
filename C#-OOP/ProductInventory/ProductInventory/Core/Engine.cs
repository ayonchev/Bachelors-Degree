using ClothingShop.Entities;
using ClothingShop.Entities.Contracts;
using ClothingShop.Entities.Products;
using ClothingShop.Entities.Products.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ClothingShop.Core
{
    public class Engine
    {
        private IInventory inventory;
        public Engine(IInventory inventory)
        {
            this.inventory = inventory;
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

                //var result = ProcessCommand(currentCommand);
            }
        }

        private void ApplicationStart()
        {
            Console.WriteLine("Hello, dear user into my Clothes Shop!");
            Console.WriteLine("Here is a list of products that we have in our shop: ");

            var types = Assembly.GetCallingAssembly().GetTypes();
            foreach (var currentType in types.Where(t => !t.IsInterface && t.BaseType.Name == typeof(Product).Name))
            {
                Console.Write(currentType.Name + '\t');
            }
            Console.WriteLine();

            Console.WriteLine("And here is a list of commands that you can execute");
            var counter = 1;
            foreach (var currentMethod in inventory.GetType().GetMethods().Where(m => m.IsFinal))
            {
                Console.WriteLine(counter++ + ". " + currentMethod.Name);
            }

            Console.WriteLine("You can create new products by specifying their price, size, manufacturer, or by creating a default one. Execute each command by specifying its full name and for example the type of product that you want to add like - \'AddProductToInventory, Shirt, 31, M, Teodor\'");
            Console.WriteLine("Let's start!");
        }

        //private string ProcessCommand(string currentCommandData)
        //{
        //    var currentCommandArgs = currentCommandData.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        //    var currentCommand = currentCommandArgs[0];

        //    switch (currentCommand)
        //    {
        //        case "AddProductToInventory":
        //            IProduct currentProduct;
        //            if (currentCommandArgs.Length > 1)
        //            {
        //                var currentPrice = double.Parse(currentCommandArgs[1]);
        //                var currentSize = (Size)Enum.Parse(typeof(Size), currentCommandArgs[2]);
        //                var currentManufacturer = currentCommandArgs.Skip(3).ToString();

        //                currentProduct = new 
        //            }
        //            break;
        //        case "AddStockOnProduct":
        //            break;
        //        case "CalculateTotalProductValue":
        //            break;
        //        case "CalculateTotalInventoryValue":
        //            break;
        //        default:
        //            throw new InvalidOperationException();
        //            break;
        //    }
        //}
    }
}
