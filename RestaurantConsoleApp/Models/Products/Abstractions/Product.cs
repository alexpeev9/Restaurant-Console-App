namespace RestaurantConsoleApp.Models.Products.Abstractions
{
    using RestaurantConsoleApp.Models.Products.Interfaces;
    using RestaurantConsoleApp.Utilities;

    public abstract class Product : IProduct
    {
        private decimal _price;
        protected Product(decimal price)
        {
            _price = price;
        }
        public decimal Price
        {
            get
            {
                return _price;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.Price), value);

                _price = value;
            }
        }
    }
}
