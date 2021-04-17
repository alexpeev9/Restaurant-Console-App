using RestaurantConsoleApp.Factories.Interfaces;
using RestaurantConsoleApp.Models.Interfaces;
using RestaurantConsoleApp.Utilities;
using System;
using System.Linq;
using System.Reflection;

namespace RestaurantConsoleApp.Factories
{
    public class ClientFactory : IClientFactory
    {
        public IBaseModel Create(string clientType, string username, decimal balance)
        {
            var clientName = clientType.ToLower();

            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == clientName);

            Validator.ThrowAnExceptionIfObjectIsNull(type, nameof(IBaseModel));

            var client = Activator.CreateInstance(type, username, balance) as IBaseModel;

            return client;
        }
    }
}
