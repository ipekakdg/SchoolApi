using SchoolApi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApi.Service.Abstract
{
    public interface IOgrenciService
    {
        List<Ogrenci> GetOgrencis();
        Ogrenci GetOgrenciById(int id);
        Ogrenci CreateOgrenci(Ogrenci ogrenci);
        Ogrenci UpdateOgrenci(Ogrenci ogrenci);
        void DeleteOgrenci(int id);
    }
}

