

using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System.Linq.Expressions;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.Get(c => c.CategoryId == id);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
