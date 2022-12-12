using Entities;
using MiBilleteraWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System.Security.Authentication;

namespace MiBilleteraWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public List<Usuario> Get()
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return db.Usuario.ToList();
            }
        }


        [HttpGet("{id}")]
        public Usuario? Get(int id)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                return new UsuarioBC().Obtener(db, id);
            }

        }

        [HttpPost]
        public void Post([FromBody] Usuario usuario)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new UsuarioBC().agregar(db, usuario);

            }

        }


        [HttpPut]
        public void Put(int id, string? Nombre, string? Apellido, long? Cuil, string? NombreUsuario, string? Email, string? Contraseña, int? IdLocalidad)
        {
            using (var db = new MiBilleteraVirtualContext())
            {
                new UsuarioBC().modificar(db, id, Nombre, Apellido, Cuil, NombreUsuario, Email, Contraseña, IdLocalidad);
            }

        }




        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                using (var db = new MiBilleteraVirtualContext())
                {

                    new UsuarioBC().eliminar(db, id);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
