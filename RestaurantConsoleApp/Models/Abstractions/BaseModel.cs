namespace RestaurantConsoleApp.Models.Abstractions
{
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Models.Inventories;
    using RestaurantConsoleApp.Utilities;

    public abstract class BaseModel : IIdentifiable , IBaseModel
    {
        private string _username;
        private decimal _balance;

        protected BaseModel(string username, decimal balance)
        {
            this.Username = username;
            this.Balance = balance;
            this.Inventory = new Inventory();
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }

            private set
            {
                Validator.ThrowAnExceptionIfDecimalIsLessThanZero(nameof(this.Balance), value);

                _balance = value;
            }
        }
        public IInventory Inventory { get; }

        public string Username
        {
            get
            {
                return _username;
            }

            private set
            {
                Validator.ThrowAnExceptionIfObjectIsNull(value, "Name");

                _username = value;
            }
        }
        public void AddToBalance(decimal price)
        {
            this.Balance += price;
        }
        public void RemoveFromBalance(decimal price)
        {
            this.Balance -= price;
        }
    }
}
