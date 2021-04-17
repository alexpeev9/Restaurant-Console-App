using RestaurantConsoleApp.Models.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp.Models.Inventories
{
    public interface IInventory
    {
        IReadOnlyCollection<IProduct> Products { get; }

        void AddProduct(IProduct product);

        bool RemoveProduct(IProduct product);

        IProduct GetProduct(string product);
    }
}
