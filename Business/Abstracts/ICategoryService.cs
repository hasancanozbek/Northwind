

using Entities.Concretes;
using System.Linq.Expressions;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category Get(Expression<Func<Category, bool>> filter);
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);
    }
}
