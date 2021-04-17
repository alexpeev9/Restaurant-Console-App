namespace RestaurantConsoleApp.Models.Products.Classes.Tacoses
{
    using RestaurantConsoleApp.Models.Products.Abstractions;
    public class BigTacos : Product
    {
        private const decimal BigTacosPrice = 7.20m;
        public BigTacos()
            : base(BigTacosPrice)
        {
        }
    }
}
