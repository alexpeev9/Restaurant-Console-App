namespace RestaurantConsoleApp.Models.Interfaces
{
    using RestaurantConsoleApp.Models.Inventories;
    public interface IBaseModel
    {
       

        decimal Balance { get; }
        IInventory Inventory { get; }

        bool IsBroke { get; }
        decimal TotalBalance { get; }
        void Transaction(decimal inputDamagePoints);
    }
}
