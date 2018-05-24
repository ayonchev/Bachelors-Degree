using ClothingShop.Entities.Contracts;
using ClothingShop.Entities.Factories;
using ClothingShop.Entities.Products;
using ClothingShop.Entities.Products.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingShop.Entities
{
    public class Inventory : IInventory
    {
        private List<IProduct> products;
        private ProductFactory factory;

        public Inventory()
        {
            this.products = new List<IProduct>();
            this.factory = new ProductFactory();
        }

        public void AddProductToInventory(Product product)
        {
            products.Add(product);
        }

        public void AddStockOnProduct(int stockValue, string productType)
        {
            for (int i = 0; i < stockValue; i++)
            {
                var currentProduct = factory.CreateProduct(productType);
                products.Add(currentProduct);
            }
        }

        public double CalculateTotalProductValue(string productType)
        {
            return products.Where(p => p.GetType().Name == productType).Sum(p => p.Price);
        }

        public double CalculateTotalInventoryValue()
        {
            return products.Sum(p => p.Price);
        }
    }
}
