namespace RestaurantConsoleApp.Factories.Interfaces
{
    using RestaurantConsoleApp.Models.Products.Interfaces;
    public interface IProductFactory
    {
        IProduct Create(string productType);
    }
}
