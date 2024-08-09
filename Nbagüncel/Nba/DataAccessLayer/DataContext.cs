using EntitiyLayer;
using EntitiyLayer.Login;
using Microsoft.EntityFrameworkCore;
using NbaWebApi.Configuration;
using NbaWebApi.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NbaWebApi.Configuration.AppUserConfiguration;

namespace DataAccessLayer
{
   public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-ITSS0P7; Database=NBALastDatabase; Trusted_Connection=true;");
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Players> oyuncular { get; set; }
        public DbSet<Teams> takimlar { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories => this.Set<Category>();
        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
        public DbSet<AppRole> AppRoles => this.Set<AppRole>();
    }
}
