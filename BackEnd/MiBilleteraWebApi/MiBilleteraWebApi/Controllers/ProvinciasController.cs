using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities;
using MiBilleteraWebApi.Models;
using Negocio;

namespace MiBilleteraWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciasController : ControllerBase
    {
        [HttpGet]
        public List<Provincia> Get()
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return db.Provincia/*.Include(a => a.Localidad)*/.ToList();
            }
        }

       
        [HttpGet("{id}")]
        public Provincia? Get(int id)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return new ProvinciaBC().ObtenerProvincia(db, id);
            }

        }

        [HttpPost]
        public void Post([FromBody] Provincia provincia)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new ProvinciaBC().agregarProvincia(db, provincia);

            }

        }


        [HttpPut]
        public void Put(int id, string NombreProvincia)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new ProvinciaBC().modificar(db, id, NombreProvincia);
            }

        }



        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                using (var db = new MiBilleteraVirtualContext())
                {
                   
                    new ProvinciaBC().eliminarProvincia(db, id);

                }

            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
