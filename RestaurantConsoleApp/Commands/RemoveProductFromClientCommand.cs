namespace RestaurantConsoleApp.Commands
{
    using RestaurantConsoleApp.Commands.Interfaces;
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Models.Products.Interfaces;
    using RestaurantConsoleApp.Repositories.Interfaces;
    using RestaurantConsoleApp.Utilities;
    public class RemoveProductFromClientCommand : ICommand
    {
        private const string SuccessfulMessage = "Successfuly removed {0} from {1}";

        private readonly IRepository<IBaseModel> _clientRepository;
        private readonly IRepository<IProduct> _productRepository;
        public RemoveProductFromClientCommand(IRepository<IBaseModel> clientRepository, IRepository<IProduct> productRepository)
        {
            _clientRepository = clientRepository;
            _productRepository = productRepository;
        }

        public string Execute(string[] inputArgs)
        {
            string productName = inputArgs[0];
            string clientUserName = inputArgs[1];

            var client = _clientRepository
                .Get(clientUserName);
            var product = _productRepository
                .Get(productName);
            client.Inventory.RemoveProduct(product);

            client.RemoveFromBalance(product.Price);

            string result = string.Format(SuccessfulMessage, productName, clientUserName);
            return result;
        }
    }
}
