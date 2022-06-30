
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concretes.EfCore
{
    public class EfProductRepository : EfBaseEntityRepository<Product, AppDbContext>, IProductRepository
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId, ProductName = p.ProductName,
                                 CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
