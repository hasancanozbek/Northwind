
using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System.Linq.Expressions;

namespace Business.Abstracts
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAllByCategory(int categoryId);
        IDataResult<List<Product>> GetAllByPrice(decimal min, decimal max);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}
