namespace RestaurantConsoleApp.Utilities
{
    using RestaurantConsoleApp.Models.Inventories;
    using RestaurantConsoleApp.Models.Products.Interfaces;
    using System;
    using System.Collections.Generic;

    public class Validator
    {
        public static void ThrowAnExceptionIfIntIsLessThanZero(string objectName, decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{objectName} cannot be less than zero!");
            }
        }

        public static void ThrowAnExceptionIfObjectIsNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentException($"{paramName} cannot be null!");
            }
        }
        public static void ThrowAnExceptionIfProductIsNotExisting(IInventory currentCollection, IProduct product)
        {
            if(!currentCollection.Products.Contains(product))
            {
                throw new ArgumentException($"{product.GetType().Name} doesn't exist in Inventory");
            }
        }
    }
}
