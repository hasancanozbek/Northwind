

using DataAccess.Abstracts;
using Entities.Concretes;
using System.Linq.Expressions;

namespace DataAccess.Concretes.InMemory
{
    public class MemoryProductRepository : IProductRepository
    {
        private List<Product> _products;    
        public MemoryProductRepository()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, ProductName="Asus Zenfone5", CategoryId=1, UnitPrice=3500, UnitsInStock=50},
                new Product{ProductId=2, ProductName="Iphone XS", CategoryId=1, UnitPrice=8000, UnitsInStock=12},
                new Product{ProductId=3, ProductName="Samsung Galaxy S10", CategoryId=1, UnitPrice=4000, UnitsInStock=35}
            };
        }

        public void Add(Product entity)
        {
            _products.Add(entity);
            Console.WriteLine($"{entity.ProductName} added to list.");
        }

        public void Delete(Product entity)
        {
            Product productToDeleted = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            _products.Remove(productToDeleted);
            Console.WriteLine($"{entity.ProductName} removed from list.");
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.FindAll(p => p.CategoryId == categoryId);
        }

        public void Update(Product entity)
        {
            Product productToUpdated  = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            _products.Remove(productToUpdated);
            Console.WriteLine($"{entity.ProductName} updated in list.");
        }
    }
}
