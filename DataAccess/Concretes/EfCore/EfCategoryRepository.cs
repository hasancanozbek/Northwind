﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EfCore
{
    public class EfCategoryRepository : EfBaseEntityRepository<Category,AppDbContext> ,ICategoryRepository
    {
    }
}
