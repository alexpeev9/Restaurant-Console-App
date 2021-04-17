namespace RestaurantConsoleApp.Models.Products.Classes.Tacoses
{
    using RestaurantConsoleApp.Models.Products.Abstractions;
    class SmallTacos : Product
    {
        private const decimal SmallTacosPrice = 4.20m;
        public SmallTacos()
            : base(SmallTacosPrice)
        {
        }
    }
}
