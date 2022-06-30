using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System.Linq.Expressions;


namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productRepository.Get(filter);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _productRepository.GetAll(filter);
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _productRepository.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetAllByPrice(decimal min, decimal max)
        {
            return _productRepository.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
