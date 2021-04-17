namespace RestaurantConsoleApp.Models.Products.Classes.Hamburgers
{
    using RestaurantConsoleApp.Models.Products.Abstractions;
    public class BeefHamburger : Product
    {
        private const decimal BeefHamburgerPrice = 3.30m;
        public BeefHamburger()
            : base(BeefHamburgerPrice)
        {
        }
    }
}
