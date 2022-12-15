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
        public void Put(int id, Double? Saldo, long? Cvu, bool? Habilitado, int? IdUsuario)
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
        
        [HttpPut]
        [Route("api/Deposito")]
        public bool Depositar(int id, long? Cvu, int Cantidad)
        {
            bool exito = false;
            using (var db = new MiBilleteraVirtualContext())
            {
                exito = new CuentaBC().Deposito(db, id, Cantidad, Cvu);
                
            }
            return exito;
        }

        [HttpPut]
        [Route("api/Extraer")]
        public bool Extraer(int id, long? Cvu, int Cantidad, long? CvuDestino, int idCuentaDestino)
        {
            
            bool exitoAll = false;
            using (var db = new MiBilleteraVirtualContext())
            {
                bool exitoDepo = new CuentaBC().Extraccion(db, id, Cantidad, Cvu);

                if (exitoDepo == true)
                {
                    exitoAll = new CuentaBC().Deposito(db, idCuentaDestino, Cantidad, CvuDestino);
                }
            }
            return exitoAll;

        }


    }
}

    

