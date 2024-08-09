using DataAccessLayer.Abstract;
using EntitiyLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class NbaRepository<T> : INbaRepository<T> where T : class
    {
        private readonly DataContext db;

        public NbaRepository(DataContext _db)
        {
           db = _db;
        }

        //public Task GetByFilterAsync => throw new NotImplementedException();

        public T CreatePT(T entity)
        {
            
                db.Set<T>().Add(entity);
                db.SaveChanges();
                return entity;
            
        }

        public void DeletePT(int id)
        {
            
                var deleted = GetByID(id);
                db.Set<T>().Remove(deleted);
                db.SaveChanges();
            
        }

        public T GetByID(int id)
        {
            
                return db.Set<T>().Find(id);
            
        }

        public List<T> Listele()
        {
            
                return db.Set<T>().ToList();
            
        }

        public DbSet<T> Set()
        {
            
                return db.Set<T>();
            
        }

        public T UpdatePT(T entity)
        {

            db.Set<T>().Update(entity);
            db.SaveChanges();
            return entity;

        }
    }
}
