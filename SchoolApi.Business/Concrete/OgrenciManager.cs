using SchoolApi.Service.Abstract;
using SchoolApi.DataAccess.Abstract;
using SchoolApi.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApi.Entities.Entities;

namespace SchoolApi.Service.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
        private IOgrenciRepository _ogrenciRepository;

        public OgrenciManager()
        {
            _ogrenciRepository = new OgrenciRepository();
        }

        public Ogrenci CreateOgrenci(Ogrenci ogrenci)
        {
            return _ogrenciRepository.CreateOgrenci(ogrenci);
        }

        public void DeleteOgrenci(int id)
        {
            _ogrenciRepository.DeleteOgrenci(id);
        }

        public Ogrenci GetOgrenciById(int id)
        {
            return _ogrenciRepository.GetOgrenciById(id);
        }

        public List<Ogrenci> GetOgrencis()
        {
            return _ogrenciRepository.GetOgrencis();
        }

        public Ogrenci UpdateOgrenci(Ogrenci ogrenci)
        {
            return _ogrenciRepository.UpdateOgrenci(ogrenci);
        }
    }
}
