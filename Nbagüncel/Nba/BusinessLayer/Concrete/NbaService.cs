using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NbaService<T> : INbaService<T> where T : class
    {
        private INbaRepository<T> rep;
        public NbaService(INbaRepository<T> _rep)
        {
            rep = _rep;
        }
        public T CreatePT(T entity)
        {
          return  rep.CreatePT(entity);
        }

        public void DeletePT(int id)
        {
            rep.DeletePT(id);
        }

        public T GetByID(int id)
        {
            return rep.GetByID(id);
        }

        public List<T> Listele()
        {
            
            return rep.Listele();
        }

        public DbSet<T> Set()
        {
            return rep.Set();
        }

        public T UpdatePT(T entity)
        {
            return rep.UpdatePT(entity);
        }
    }
}
