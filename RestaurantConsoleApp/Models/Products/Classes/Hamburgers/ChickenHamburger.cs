namespace RestaurantConsoleApp.Models.Products.Classes.Hamburgers
{
    using RestaurantConsoleApp.Models.Products.Abstractions;
    public class ChickenHamburger : Product
    {
        private const decimal ChickenHamburgerPrice = 3.30m;
        public ChickenHamburger()
            : base(ChickenHamburgerPrice)
        {
        }
    }
}
