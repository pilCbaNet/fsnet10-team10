using Entities;
using MiBilleteraWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace MiBilleteraWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {

        [HttpGet]
        public List<Operacion> Get()
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return db.Operacion.ToList();
            }
        }


        [HttpGet("{id}")]
        public Operacion? Get(int id)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return new OperacionBC().Obtener(db, id);
            }

        }

        [HttpPost]
        public void Post([FromBody] Operacion operacion)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new OperacionBC().agregar(db, operacion);

            }

        }


        [HttpPut]
        public void Put(int id, DateTime? Fecha, double? Monto, bool? Deposito, bool? Extraccion, int? IdCuenta)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new OperacionBC().modificar(db, id, Fecha, Monto, Deposito, Extraccion, IdCuenta);
            }

        }




        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                using (var db = new MiBilleteraVirtualContext())
                {

                    new OperacionBC().eliminar(db, id);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("api/UltimosMovimientosAll")]
        public List<Operacion> GetUltimosMoviminetosAll(int idCuenta)
        {
            List<Operacion> oListaResult;
            using (var db = new MiBilleteraVirtualContext())
            {
                oListaResult = new UltimosMovimientosBC().ObtenerOperacion(db, idCuenta);
            }
            return oListaResult;
        }
        [HttpGet]
        [Route("api/UltimosMovimientos")]
        public List<Operacion> GetUltimosMoviminetos(int idCuenta, int cantidad)
        {
            List<Operacion> oListaResult;
            using (var db = new MiBilleteraVirtualContext())
            {
                oListaResult = new UltimosMovimientosBC().ObtenerOperacion(db, idCuenta, cantidad);
            }
            return oListaResult;
        }
    }
}
