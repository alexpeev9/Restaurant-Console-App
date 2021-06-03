namespace RestaurantConsoleApp.Factories
{
    using RestaurantConsoleApp.Factories.Interfaces;
    using RestaurantConsoleApp.Models.Products.Interfaces;
    using RestaurantConsoleApp.Utilities;
    using System;
    using System.Linq;
    using System.Reflection;
    public class ProductFactory : IProductFactory
    {
        public IProduct Create(string productType)
        {
            var productName = productType.ToLower();

            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == productName);

            Validator.ThrowAnExceptionIfObjectIsNull(type, "Product");

            var product = Activator.CreateInstance(type) as IProduct;

            return product;
        }
    }
}