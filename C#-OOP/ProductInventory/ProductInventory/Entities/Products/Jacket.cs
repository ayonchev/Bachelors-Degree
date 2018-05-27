namespace ClothingShop.Entities.Products
{
    public class Jacket : Product
    {
        private const double defaultPrice = 120;
        private const string defaultManufacturer = "Phillip Plein";
        private const Size defaultSize = Size.M;

        public Jacket() : base(defaultPrice, defaultSize, defaultManufacturer)
        {
        }

        public Jacket(double price, Size size, string manufacturer) : base(price, size, manufacturer)
        {
        }
    }
}
