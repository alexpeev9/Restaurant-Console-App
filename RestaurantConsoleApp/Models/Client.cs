using RestaurantConsoleApp.Models.Abstractions;

namespace RestaurantConsoleApp.Models
{
    public class Client : BaseModel
    {
        public Client(string username, decimal balance) : base(username, balance)
        {
        }
    }
}
