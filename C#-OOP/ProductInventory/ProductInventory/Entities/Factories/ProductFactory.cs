namespace ClothingShop.Entities.Factories
{
    using ClothingShop.Entities.Products.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class ProductFactory
    {
        public IProduct CreateProduct(string productType)
        {
            var currentType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(t => t.Name == productType);
            var instance = (IProduct)Activator.CreateInstance(currentType);
            return instance;
        }

        public IProduct CreateProduct(string productType, double price, Size size, string manufacturer)
        {
            var currentType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(t => t.Name == productType);
            var instance = (IProduct)Activator.CreateInstance(currentType, new object[] { price, size, manufacturer });
            return instance;
        }
    }
}
