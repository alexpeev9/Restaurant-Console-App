namespace RestaurantConsoleApp.Models.Products.Pizzas
{
    using RestaurantConsoleApp.Models.Products.Abstractions;
    public class DiavoloPizza : Product
    {
        private const decimal DiavoloPizzaBalance = 5m;
        public DiavoloPizza()
            : base(DiavoloPizzaBalance)
        {
        }
    }
}
