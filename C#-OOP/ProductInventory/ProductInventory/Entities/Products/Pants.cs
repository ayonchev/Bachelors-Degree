using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop.Entities.Products
{
    public class Pants : Product
    {
        private const double defaultPrice = 70;
        private const string defaultManufacturer = "Bershka";
        private const Size defaultSize = Size.S;

        public Pants() : base(defaultPrice, defaultSize, defaultManufacturer)
        {
        }

        public Pants(double price, Size size, string manufacturer) : base(price, size, manufacturer)
        {
        }
    }
}
