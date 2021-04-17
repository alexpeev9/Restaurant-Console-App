namespace RestaurantConsoleApp.Models.Inventories
{
    using RestaurantConsoleApp.Models.Products.Interfaces;
    using RestaurantConsoleApp.Utilities;
    using System.Collections.Generic;
    using System.Linq;
    public class Inventory : IInventory
    {
        private readonly List<IProduct> _products;
        public Inventory()
        {
            _products = new List<IProduct>();
        }
        public IReadOnlyCollection<IProduct> Products =>
            _products.AsReadOnly();
        public void AddProduct(IProduct product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, nameof(product));

            _products.Add(product);
        }
        public bool RemoveProduct(IProduct product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, nameof(product));

            bool isRemove = _products.Remove(product);

            return isRemove;
        }
        public IProduct GetProduct(string product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, nameof(product));

            var targetProduct = _products
                .FirstOrDefault(i => i.GetType().Name == product);

            return targetProduct;
        }
        public override string ToString()
        {
            return "\n"+string.Join("\n", _products.Select( x=> x.GetType().Name));
        }
    }
}
