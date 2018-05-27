namespace ClothingShop.Entities.Products.Contracts
{
    public interface IProduct
    {
        double Price { get; }

        Size Size { get; }

        string Manufacturer { get; }
    }
}
