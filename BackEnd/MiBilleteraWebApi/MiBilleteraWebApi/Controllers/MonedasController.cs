using Entities;
using MiBilleteraWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace MiBilleteraWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedasController : ControllerBase
    {

        [HttpGet]
        public List<Moneda> Get()
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return db.Moneda.ToList();
            }
        }


        [HttpGet("{id}")]
        public Moneda? Get(int id)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return new MonedaBC().Obtener(db, id);
            }

        }

        [HttpPost]
        public void Post([FromBody] Moneda moneda)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new MonedaBC().agregar(db, moneda);

            }

        }


        [HttpPut]
        public void Put(int id, double? Monto, string? Nombre, int? idUsuario)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new MonedaBC().modificar(db, id, Monto, Nombre, idUsuario);
            }

        }




        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                using (var db = new MiBilleteraVirtualContext())
                {

                    new MonedaBC().eliminar(db, id);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
