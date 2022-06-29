
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
