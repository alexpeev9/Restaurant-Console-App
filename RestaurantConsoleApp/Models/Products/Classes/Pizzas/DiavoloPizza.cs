namespace RestaurantConsoleApp.Models.Products.Classes.Pizzas
{
    using RestaurantConsoleApp.Models.Products.Abstractions;
    public class DiavoloPizza : Product
    {
        private const decimal DiavoloPizzaPrice = 5.50m;
        public DiavoloPizza()
            : base(DiavoloPizzaPrice)
        {
        }
    }
}
