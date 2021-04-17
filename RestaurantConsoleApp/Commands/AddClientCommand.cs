using RestaurantConsoleApp.Commands.Interfaces;
using RestaurantConsoleApp.Factories.Interfaces;
using RestaurantConsoleApp.Models.Interfaces;
using RestaurantConsoleApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp.Commands
{
    public class AddClientCommand : ICommand
    {
        private const string SuccessfullyAddedMessage = "Successfully created Client: {0}!";

        private readonly IRepository<IBaseModel> _clientRepository;
        private readonly IClientFactory _clientFactory;

        public AddClientCommand(IRepository<IBaseModel> clientRepository, IClientFactory clientFactory)
        {
            _clientRepository = clientRepository;
            _clientFactory = clientFactory;
        }

        public string Execute(string[] inputArgs)
        {
            string clientType = inputArgs[0];
            string username = inputArgs[1];
            var client = _clientFactory.Create(clientType, username);

            _clientRepository.Add(client);

            string result = string.Format(SuccessfullyAddedMessage, username);

            return result;
        }
    }
}
