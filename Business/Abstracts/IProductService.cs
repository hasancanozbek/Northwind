
using Entities.Concretes;
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
        Product Get(Expression<Func<Product, bool>> filter);
        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
    }
}
