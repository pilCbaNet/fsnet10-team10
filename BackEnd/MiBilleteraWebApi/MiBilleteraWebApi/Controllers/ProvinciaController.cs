using MiBilleteraWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace MiBilleteraWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        [HttpGet]
        public List<Provincias> Get()
        {
            using (var db = new BilleteraVirtualContext())
            {
                return db.Provincia.ToList();
            }
        }

        [HttpPost]
        public void Post([FromBody] Provincias provincia)
        {
            using (var db = new BilleteraVirtualContext())
            {
                db.Provincia.Add(provincia);
                db.SaveChanges();
            }
        }
    }
}
