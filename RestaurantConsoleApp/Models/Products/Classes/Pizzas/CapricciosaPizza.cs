namespace RestaurantConsoleApp.Models.Products.Classes.Pizzas
{
    using RestaurantConsoleApp.Models.Products.Abstractions;
    public class CapricciosaPizza : Product
    {
        private const decimal CapricciosaPizzaPrice = 10m;
        public CapricciosaPizza()
            : base(CapricciosaPizzaPrice)
        {
        }
    }
}
