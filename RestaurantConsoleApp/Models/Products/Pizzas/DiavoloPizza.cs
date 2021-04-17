namespace RestaurantConsoleApp.Models.Products.Pizzas
{
    using RestaurantConsoleApp.Models.Products.Abstractions;
    public class DiavoloPizza : Product
    {
        private const decimal DiavoloPizzaBalance = 5.50m;
        public DiavoloPizza()
            : base(DiavoloPizzaBalance)
        {
        }
    }
}
