namespace RestaurantConsoleApp.Repositories
{
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Repositories.Interfaces;
    using RestaurantConsoleApp.Utilities;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    class ProductRepository : IRepository<IBaseModel>
    {
        private readonly ICollection<IBaseModel> _productRepository;

        public ProductRepository()
        {
            _productRepository = new List<IBaseModel>();
        }

        public IReadOnlyCollection<IBaseModel> Repository
            => _productRepository.ToImmutableArray();

        public void Add(IBaseModel product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, nameof(product));
            _productRepository.Add(product);
        }

        public IBaseModel Get(string product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, nameof(product));

            var targetProduct = _productRepository
                .FirstOrDefault(x => x.GetType().Name == product);

            return targetProduct;
        }

        public bool Remove(IBaseModel product)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(product, nameof(product));
            bool isRemoved = _productRepository.Remove(product);

            return isRemoved;
        }
    }
}
