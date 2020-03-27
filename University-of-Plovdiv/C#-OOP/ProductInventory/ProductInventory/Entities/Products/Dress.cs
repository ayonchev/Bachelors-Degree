namespace ClothingShop.Entities.Products
{
    class Dress : Product
    {
        private const double defaultPrice = 80;
        private const string defaultManufacturer = "New Yorker";
        private const Size defaultSize = Size.XS;

        public Dress() : base(defaultPrice, defaultSize, defaultManufacturer)
        {
        }

        public Dress(double price, Size size, string manufacturer) : base(price, size, manufacturer)
        {
        }
    }
}
