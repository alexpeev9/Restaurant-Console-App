﻿namespace RestaurantConsoleApp.Models.Abstractions
{
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Models.Inventories;
    using RestaurantConsoleApp.Utilities;
    using System;
    using System.Linq;

    public abstract class BaseModel : IIdentifiable , IBaseModel
    {
        private string username;
        private decimal balance;
        private decimal totalBalance;

        protected BaseModel(string username, decimal balance)
        {
            this.Username = username;
            this.Balance = balance ;
            this.Inventory = new Inventory();
            this.TotalBalance = this.GetTotalBalance();
        }
        public IInventory Inventory { get; }

        public bool IsBroke
            => this.TotalBalance > 0;

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
        public decimal TotalBalance
        {
            get
            {
                return this.totalBalance;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.TotalBalance), value);

                this.totalBalance = value;
            }
        }

        private decimal GetTotalBalance()
          => this.totalBalance = this.Balance -
                                       this.Inventory.Products.Sum(x => x.Price);

        public void Transaction(decimal inputDamagePoints)
        {
            if (!this.IsBroke)
            {
                throw new InvalidOperationException("You are broke!");
            }

            if (this.TotalBalance > 0)
            {
                this.TotalBalance  -= inputDamagePoints;
            }
        }
    }
}
