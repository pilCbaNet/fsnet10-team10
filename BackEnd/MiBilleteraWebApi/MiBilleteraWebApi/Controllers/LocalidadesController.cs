using Entities;
using MiBilleteraWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace MiBilleteraWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadesController : ControllerBase
    {



        [HttpGet]
        public List<Localidad> Get()
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return db.Localidad.ToList();
            }
        }


        [HttpGet("{id}")]
        public Localidad? Get(int id)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return new LocalidadBC().Obtener(db, id);
            }

        }

        [HttpPost]
        public void Post([FromBody] Localidad localidad)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new LocalidadBC().agregar(db, localidad);

            }

        }


        [HttpPut]
        public void Put(int id, string? NombreLocalidad, string? Domicilio, int? idProvincia)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new LocalidadBC().modificar(db, id, NombreLocalidad, Domicilio, idProvincia);
            }

        }




        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                using (var db = new MiBilleteraVirtualContext())
                {

                    new LocalidadBC().eliminar(db, id);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
