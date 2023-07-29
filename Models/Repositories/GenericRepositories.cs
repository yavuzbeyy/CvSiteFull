﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MyWebCv.Models.Entity;

namespace MyWebCv.Repositories
{
    public class GenericRepositories<T> where T : class, new()
    {
        Db_CvEntities db = new Db_CvEntities();

        public List<T> List(){

            return db.Set<T>().ToList();

        }

        public void Tadd(T p)
        {

            db.Set<T>().Add(p);
            db.SaveChanges();
        }

        public void TDelete(T p)
        {

            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        public T TGet(int id)
        {
            return db.Set<T>().Find();
        }

        internal void TAdd(Education_Table p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(T p)
        {
            db.SaveChanges();
        }

        public T Find(Expression<Func<T,bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}