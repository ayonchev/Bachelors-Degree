namespace ProductInventory
{
    using ClothingShop.Core;
    using ClothingShop.Entities;

    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            var engine = new Engine(inventory);

            engine.Run();
        }
    }
}