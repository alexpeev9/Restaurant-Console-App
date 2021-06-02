namespace RestaurantConsoleApp.Commands
{
    using RestaurantConsoleApp.Commands.Interfaces;
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Repositories.Interfaces;
    using System;
    public class ShowInventoryCommand : ICommand
    {
        private const string SuccessfulMessage = "Customer: {0}\nInventory: {1}\nBalance: {2}";

        private readonly IRepository<IBaseModel> _clientRepository;
        
        public ShowInventoryCommand(IRepository<IBaseModel> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public string Execute(string[] inputArgs)
        {
            string clientUserName = inputArgs[0];

            var client = _clientRepository
                .Get(clientUserName);
            string inventory = String.Join(",",client.Inventory);
            string balance = client.Balance.ToString("F");
            string result = string.Format(SuccessfulMessage, clientUserName, inventory, balance);

            return result;
        }
    }
}