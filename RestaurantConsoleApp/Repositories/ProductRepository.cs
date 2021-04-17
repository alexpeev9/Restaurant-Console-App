namespace RestaurantConsoleApp.Repositories
{
    using RestaurantConsoleApp.Models.Products.Interfaces;
    using RestaurantConsoleApp.Repositories.Interfaces;
    using RestaurantConsoleApp.Utilities;
    using System.Collections.Generic;
    using System.Linq;
    public class ProductRepository : IRepository<IProduct>
    {
        private readonly ICollection<IProduct> _productRepository;
        private readonly string productTitle = "Product";
        public ProductRepository()
        {
            _productRepository = new List<IProduct>();
        }

        public ICollection<IProduct> Repository
            => _productRepository.ToList();

        public void Add(IProduct product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, productTitle);
            _productRepository.Add(product);
        }

        public IProduct Get(string product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, productTitle);

            var targetProduct = _productRepository
                .FirstOrDefault(x => x.GetType().Name == product);

            return targetProduct;
        }

        public bool Remove(IProduct product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, productTitle);
            bool isRemoved = _productRepository.Remove(product);
            return isRemoved;
        }
    }
}
