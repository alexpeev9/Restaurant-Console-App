namespace RestaurantConsoleApp.Factories
{
    using RestaurantConsoleApp.Factories.Interfaces;
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Utilities;
    using System;
    using System.Linq;
    using System.Reflection;
    public class ClientFactory : IClientFactory
    {
        public IBaseModel Create(string clientType, string username)
        {
            var clientName = clientType.ToLower();

            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == clientName);

            Validator.ThrowAnExceptionIfObjectIsNull(type, "Client");

            var client = Activator.CreateInstance(type, username) as IBaseModel;

            return client;
        }
    }
}
