

using Entities.Concretes;
using System.Linq.Expressions;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetById(int id);
        List<Category> GetAll();
    }
}
