using ClothingShop.Entities.Products.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ClothingShop.Entities.Factories
{
    public class ProductFactory
    {
        public IProduct CreateProduct(string productType)
        {
            var currentType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(t => t.Name == productType);
            var instance = (IProduct)Activator.CreateInstance(currentType);
            return instance;
        }
    }
}
