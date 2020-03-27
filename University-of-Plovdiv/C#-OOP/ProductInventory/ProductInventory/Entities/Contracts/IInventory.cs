namespace ClothingShop.Entities.Contracts
{
    using ClothingShop.Entities.Products.Contracts;

    public interface IInventory
    {
        void AddProductToInventory(IProduct product);

        void AddStockOnProduct(int value, string productType);

        double CalculateTotalProductValue(string productType);

        double CalculateTotalInventoryValue();
    }
}
