using RestaurantConsoleApp.Models.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp.Models.Products.Pizzas
{
    public class CapricciosaPizza : Product
    {
        private const decimal CapricciosaPizzaBalance = 10m;
        public CapricciosaPizza()
            : base(CapricciosaPizzaBalance)
        {
        }
    }
}
