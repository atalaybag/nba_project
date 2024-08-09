using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class StoreRepository<T> : IStoreRepository<T> where T : class, new()
    {
        private readonly DataContext db;

        public StoreRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task CreateAsync(T entity)
        {
            await this.db.Set<T>().AddAsync(entity);
            await this.db.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this.db.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this.db.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetByIDAsync(object id)
        {
            return await this.db.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
             this.db.Set<T>().Remove(entity);
            await db.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            this.db.Set<T>().Update(entity);
            await this.db.SaveChangesAsync();
        }
    }
}
