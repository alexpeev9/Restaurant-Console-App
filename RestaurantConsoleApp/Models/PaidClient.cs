namespace RestaurantConsoleApp.Models
{
    using RestaurantConsoleApp.Models.Abstractions;
    public class PaidClient : BaseModel
    {
        private const int PaidClientBalance = 5;
        public PaidClient(string username) : base(username, PaidClientBalance)
        {
        }
    }
}
