namespace RestaurantConsoleApp.Models.Interfaces
{
    using RestaurantConsoleApp.Models.Inventories;
    public interface IBaseModel
    {
        decimal Balance { get; }
        IInventory Inventory { get; }
        void AddToBalance(decimal price);
        void RemoveFromBalance(decimal price);
    }
}
