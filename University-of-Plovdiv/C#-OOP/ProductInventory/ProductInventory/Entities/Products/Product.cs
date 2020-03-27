namespace ClothingShop.Entities.Products
{
    using ClothingShop.Entities.Products.Contracts;
    using System;

    public abstract class Product : IProduct
    {
        public Product(double price, Size size, string manufacturer)
        {
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Size = size;
        }

        public double Price { get; private set; }

        public string Manufacturer { get; private set; }

        public Size Size { get; private set; }
    }
}
