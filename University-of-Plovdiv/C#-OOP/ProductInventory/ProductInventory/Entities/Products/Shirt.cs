namespace ClothingShop.Entities.Products
{
    public class Shirt : Product
    {
        private const double defaultPrice = 40;
        private const string defaultManufacturer = "Teodor";
        private const Size defaultSize = Size.L;

        public Shirt() : base(defaultPrice, defaultSize, defaultManufacturer)
        {
        }

        public Shirt(double price, Size size, string manufacturer) : base(price, size, manufacturer)
        {
        }
    }
}
