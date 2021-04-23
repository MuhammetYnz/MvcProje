﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        Context context = new Context();
        DbSet<Category> _object;
        public void Delete(Category c)
        {
            _object.Remove(c);
            context.SaveChanges();
        }

        public void Insert(Category c)
        {
            _object.Add(c);
            context.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Update(Category c)
        {
            context.SaveChanges();
        }
    }
}