using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
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

        public Product GetById(int id)
        {
            return _productRepository.Get(p => p.ProductId == id);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _productRepository.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetAllByPrice(decimal min, decimal max)
        {
            return _productRepository.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productRepository.GetProductDetails();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
