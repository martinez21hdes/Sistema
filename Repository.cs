using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Academico.DAL.DataModels;
using System.Data.Entity;

namespace Sistema_Academico.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private Data Context;
        private DbSet<T> dbSet;

        public Repository(Data context)
        {
            Context = context;
            dbSet = context.Set<T>();
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Attach(entity);
            dbSet.Remove(entity);
        }

        public T Find(params object[] keyValue)
        {
            return dbSet.Find(keyValue);
        }

        public IQueryable<T> Get()
        {
            return dbSet;
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }
    }    }
