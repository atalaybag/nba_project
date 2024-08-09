using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public  interface INbaRepository<T> where T:class
    {
        //Task GetByFilterAsync { get; }

        DbSet<T> Set();
        List<T> Listele();
        T GetByID(int id);
        T CreatePT(T entity);
        T UpdatePT(T entity);
        void DeletePT(int id);

    }
}
