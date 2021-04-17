using RestaurantConsoleApp.Models.Interfaces;

namespace RestaurantConsoleApp.Factories.Interfaces
{
    public interface IClientFactory
    {
        IBaseModel Create(string clientType, string username, decimal balance);

    }
}
