using RestaurantConsoleApp.Commands.Interfaces;
using RestaurantConsoleApp.Factories;
using RestaurantConsoleApp.Factories.Interfaces;
using RestaurantConsoleApp.Models.Products.Interfaces;
using RestaurantConsoleApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp.Commands
{
    public class AddProductCommand : ICommand
    {
        private const string SuccessfullyAddedMessage = "Successfully added: {0}!";

        private readonly IRepository<IProduct> _productRepository;
        private readonly IProductFactory _productFactory;

        public AddProductCommand(IRepository<IProduct> productRepository, IProductFactory productFactory)
        {
            _productRepository = productRepository;
            _productFactory = productFactory;
        }
        public string Execute(string[] inputArgs)
        {
            var productType = inputArgs[0];
            
            var product = _productFactory.Create(productType);

            _productRepository.Add(product);

            string result = string.Format(SuccessfullyAddedMessage, product.GetType().Name);

            return result;
        }
    }
}
