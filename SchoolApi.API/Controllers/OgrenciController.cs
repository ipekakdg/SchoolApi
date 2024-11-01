using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Entities.Entities;
using SchoolApi.Service.Abstract;
using SchoolApi.Service.Concrete;

namespace SchoolAutomation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {
        private IOgrenciService _ogrenciService;

        public OgrenciController()
        {
            _ogrenciService = new OgrenciManager();
        }
        [HttpGet]
        public List<Ogrenci> Get()
        {
            return _ogrenciService.GetOgrencis();
        }

        [HttpGet("{id}")]
        public Ogrenci Get(int id)
        {
            return _ogrenciService.GetOgrenciById(id);
        }

        [HttpPost]
        public Ogrenci Post([FromBody] Ogrenci ogrenci)
        {
            return _ogrenciService.CreateOgrenci(ogrenci);
        }

        [HttpPut]
        public Ogrenci Put([FromBody] Ogrenci ogrenci)
        {
            return _ogrenciService.UpdateOgrenci(ogrenci);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _ogrenciService.DeleteOgrenci(id);
        }
    }
}
