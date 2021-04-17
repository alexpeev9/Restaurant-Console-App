using RestaurantConsoleApp.Factories.Interfaces;
using RestaurantConsoleApp.Models.Interfaces;
using RestaurantConsoleApp.Models.Products.Interfaces;
using RestaurantConsoleApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RestaurantConsoleApp.Factories
{
    public class ProductFactory : IProductFactory
    {
        public IProduct Create(string productType)
        {
            var productName = productType.ToLower();

            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == productName);

            Validator.ThrowAnExceptionIfObjectIsNull(type, nameof(IProduct));

            var product = Activator.CreateInstance(type) as IProduct;

            return product;
        }
    }
}