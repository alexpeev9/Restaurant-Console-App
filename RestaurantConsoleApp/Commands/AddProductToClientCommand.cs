using RestaurantConsoleApp.Commands.Interfaces;
using RestaurantConsoleApp.Factories.Interfaces;
using RestaurantConsoleApp.Models.Interfaces;
using RestaurantConsoleApp.Models.Products.Interfaces;
using RestaurantConsoleApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp.Commands
{
    public class AddProductToClientCommand : ICommand
    {
        private const string SuccessfulMessage = "Successfuly added {0} to {1}";

        private readonly IRepository<IBaseModel> _clientRepository;
        private readonly IRepository<IProduct> _productRepository;
        private readonly IProductFactory _productFactory;
        public AddProductToClientCommand(IRepository<IBaseModel> clientRepository, IRepository<IProduct> productRepository)
        {
            _clientRepository = clientRepository;
            _productRepository = productRepository;
        }

        public string Execute(string[] inputArgs)
        {
            string clientUserName = inputArgs[0];
            string productName = inputArgs[1];

            var client = _clientRepository
                .Get(clientUserName);
            var product = _productRepository
                .Get(productName);

            client.Inventory.AddProduct(product);
            client.AddToBalance(product.Price);
            string result = string.Format(SuccessfulMessage, productName, clientUserName);
            return result;
        }
    }
}
