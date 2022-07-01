
using Entities.Concretes;
using Entities.DTOs;
using System.Linq.Expressions;

namespace Business.Abstracts
{
    public interface IProductService
    {
        List<Product> GetAllByCategory(int categoryId);
        List<Product> GetAllByPrice(decimal min, decimal max);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product GetById(int id);
        List<Product> GetAll();
        List<ProductDetailDto> GetProductDetails();
    }
}
