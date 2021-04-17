namespace RestaurantConsoleApp.Models.Abstractions
{
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Models.Inventories;
    using RestaurantConsoleApp.Models.Products.Interfaces;
    using RestaurantConsoleApp.Utilities;
    using System;
    using System.Linq;

    public abstract class BaseModel : IIdentifiable , IBaseModel
    {
        private string username;
        private decimal balance;

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
                return this.balance;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.Balance), value);

                this.balance = value;
            }
        }
        public IInventory Inventory { get; }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                Validator.ThrowAnExceptionIfObjectIsNull(value, nameof(this.Username));

                this.username = value;
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
