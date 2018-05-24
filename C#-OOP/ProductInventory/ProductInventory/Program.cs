using ClothingShop.Core;
using ClothingShop.Entities;
using ClothingShop.Entities.Products;
using ClothingShop.Entities.Products.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            var engine = new Engine(inventory);

            engine.Run();
        }
    }
}