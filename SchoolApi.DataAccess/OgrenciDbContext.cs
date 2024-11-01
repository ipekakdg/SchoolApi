using Microsoft.EntityFrameworkCore;
using SchoolApi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApi.DataAccess
{
    public class OgrenciDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Initial Catalog=Universite; integrated security=true;");
        }
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Bolum> Bolums { get; set; }
    }
}
