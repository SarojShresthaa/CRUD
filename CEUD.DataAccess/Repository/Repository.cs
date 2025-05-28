using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.DataAccess.Data;
using CRUD.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace CRUD.DataAccess.Repository
{
    public class Repository <T>: IRepository<T> where T : class
        {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet; // DbSet is a class that represents a collection of entities of a specific type in the database context.
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }
        public T Get(int id)
        {
            return dbSet.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }
        public void Remove(int id)
        {
            T entityToDelete = dbSet.Find(id);
            Remove(entityToDelete);
        }
        public void Remove(T entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }
    }
  
}
