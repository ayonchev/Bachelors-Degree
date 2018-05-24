using ClothingShop.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingShop.Entities.Contracts
{
    public interface IInventory
    {
        void AddProductToInventory(Product product);

        void AddStockOnProduct(int value, string productType);

        double CalculateTotalProductValue(string productType);

        double CalculateTotalInventoryValue();
    }
}
