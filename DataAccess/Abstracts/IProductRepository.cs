
using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;

namespace DataAccess.Abstracts
{
    public interface IProductRepository:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
