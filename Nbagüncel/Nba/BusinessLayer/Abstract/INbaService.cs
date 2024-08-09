using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface INbaService<T> where T:class
    {
        DbSet<T> Set();
        List<T> Listele();
        T GetByID(int id);
        T CreatePT(T entity);
        T UpdatePT(T entity);
        void DeletePT(int id);
    }
}
