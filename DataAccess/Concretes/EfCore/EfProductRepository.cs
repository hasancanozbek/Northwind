
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concretes.EfCore
{
    public class EfProductRepository : EfBaseEntityRepository<Product,AppDbContext>, IProductRepository
    {
        
    }
}
