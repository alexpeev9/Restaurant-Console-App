namespace RestaurantConsoleApp.Repositories
{
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Models.Products.Interfaces;
    using RestaurantConsoleApp.Repositories.Interfaces;
    using RestaurantConsoleApp.Utilities;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    class ProductRepository : IRepository<IProduct>
    {
        private readonly ICollection<IProduct> _productRepository;

        public ProductRepository()
        {
            _productRepository = new List<IProduct>();
        }

        public IReadOnlyCollection<IProduct> Repository
            => _productRepository.ToImmutableArray();

        public void Add(IProduct product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, nameof(product));
            _productRepository.Add(product);
        }

        public IProduct Get(string product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, nameof(product));

            var targetProduct = _productRepository
                .FirstOrDefault(x => x.GetType().Name == product);

            return targetProduct;
        }

        public bool Remove(IProduct product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, nameof(product));
            bool isRemoved = _productRepository.Remove(product);

            return isRemoved;
        }
    }
}
