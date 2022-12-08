using Entities;
using MiBilleteraWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace MiBilleteraWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentasController : ControllerBase
    {
        [HttpGet]
        public List<Cuenta> Get()
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return db.Cuenta.ToList();
            }
        }


        [HttpGet("{id}")]
        public Cuenta? Get(int id)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return new CuentaBC().Obtener(db, id);
            }

        }

        [HttpPost]
        public void Post([FromBody] Cuenta cuenta)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new CuentaBC().agregar(db, cuenta);

            }

        }


        [HttpPut]
        public void Put(int id, double? Saldo, long? Cvu, bool? Habilitado, int? IdUsuario)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new CuentaBC().modificar(db, id, Saldo, Cvu, Habilitado, IdUsuario);
            }

        }




        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                using (var db = new MiBilleteraVirtualContext())
                {

                    new CuentaBC().eliminar(db, id);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
