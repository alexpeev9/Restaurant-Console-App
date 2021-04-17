namespace RestaurantConsoleApp.Repositories
{
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Repositories.Interfaces;
    using RestaurantConsoleApp.Utilities;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    public class ClientRepository : IRepository<IBaseModel>
    {
        private readonly ICollection<IBaseModel> _clients;
        private readonly string clientTitle = "Client";

        public ClientRepository()
        {
            _clients = new List<IBaseModel>();
        }

        public ICollection<IBaseModel> Repository
           => _clients.ToImmutableArray();

        public void Add(IBaseModel client)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(client, clientTitle);
            _clients.Add(client);
        }

        public IBaseModel Get(string client)
        {
            var targetClient = _clients.
                FirstOrDefault(h => (h as IIdentifiable)?.Username == client);
            Validator.ThrowAnExceptionIfObjectIsNull(targetClient, clientTitle);
            return targetClient;
        }

        public bool Remove(IBaseModel client)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(client, clientTitle);
            bool isRemoved = _clients.Remove(client);
            return isRemoved;
        }
    }
}