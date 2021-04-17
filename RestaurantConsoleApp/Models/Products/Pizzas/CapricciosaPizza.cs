namespace RestaurantConsoleApp.Models.Products.Pizzas
{
    using RestaurantConsoleApp.Models.Products.Abstractions;
    public class CapricciosaPizza : Product
    {
        private const decimal CapricciosaPizzaBalance = 10m;
        public CapricciosaPizza()
            : base(CapricciosaPizzaBalance)
        {
        }
    }
}
