using RestaurantConsoleApp.Models.Abstractions;

namespace RestaurantConsoleApp.Models
{
    public class Client : BaseModel
    {
        private const int ClientBalance = 0;
        public Client(string username) : base(username, ClientBalance)
        {
        }
    }
}
