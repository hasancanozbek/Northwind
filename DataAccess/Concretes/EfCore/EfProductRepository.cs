
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concretes.EfCore
{
    public class EfProductRepository : IProductRepository
    {
        public void Add(Product entity)
        {
            using (AppDbContext context = new AppDbContext())
            {
                //context.Entry(entity).State = EntityState.Added;
                context.Products.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Products.Remove(entity);
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Products.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
