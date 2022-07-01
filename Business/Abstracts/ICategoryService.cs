

using Core.Utilities.Results;
using Entities.Concretes;
using System.Linq.Expressions;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
        IDataResult<Category> GetById(int id);
        IDataResult<List<Category>> GetAll();
    }
}
