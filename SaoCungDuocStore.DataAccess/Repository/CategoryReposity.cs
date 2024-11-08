﻿using SaoCungDuocStore.DataAccess.Data;
using SaoCungDuocStore.DataAccess.Repository.IRepository;
using SaoCungDuocStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SaoCungDuocStore.DataAccess.Repository
{
    public class CategoryReposity : Repository<Category>, ICategoryRepository 
    {

        private ApplicationDbContext _db;
        public CategoryReposity(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

      

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
