using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Entities.Entities
{
    public class Ogrenci
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Numarasi { get; set; }

        public string Email { get; set; }

        public string Parolasi { get; set; }

        public int BolumId { get; set; }

    }
}