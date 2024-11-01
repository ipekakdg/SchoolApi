using SchoolApi.DataAccess.Abstract;
using SchoolApi.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApi.Entities.Entities;

namespace SchoolApi.DataAccess.Concrete
{
    public class OgrenciRepository : IOgrenciRepository
    {
        public Ogrenci CreateOgrenci(Ogrenci ogrenci)
        {
            using (var ogrenciDbContext = new OgrenciDbContext())
            {
                ogrenciDbContext.Ogrencis.Add(ogrenci);
                ogrenciDbContext.SaveChanges();
                return ogrenci;
            }
        }

        public void DeleteOgrenci(int id)
        {
            using (var ogrenciDbContext = new OgrenciDbContext())
            {
                var deletedOgrenci = GetOgrenciById(id);
                ogrenciDbContext.Ogrencis.Remove(deletedOgrenci);
                ogrenciDbContext.SaveChanges();
            }
        }

        public Ogrenci GetOgrenciById(int id)
        {
            using (var ogrenciDbContext = new OgrenciDbContext())
            {
                return ogrenciDbContext.Ogrencis.Find(id);
            }
        }

        public List<Ogrenci> GetOgrencis()
        {
            using (var ogrenciDbContext = new OgrenciDbContext())
            {
                return ogrenciDbContext.Ogrencis.ToList();
            }
        }

        public Ogrenci UpdateOgrenci(Ogrenci ogrenci)
        {
            using (var ogrenciDbContext = new OgrenciDbContext())
            {
                ogrenciDbContext.Ogrencis.Update(ogrenci);
                ogrenciDbContext.SaveChanges();
                return ogrenci;
            }
        }
    }
}
