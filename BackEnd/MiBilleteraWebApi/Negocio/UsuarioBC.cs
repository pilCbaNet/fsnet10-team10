using Entities;
using MiBilleteraWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioBC
    {
        //get by id
        public Usuario? Obtener(MiBilleteraVirtualContext db, int id)
        {
            return db.Usuario.FirstOrDefault(a => a.IdUsuario == id);
        }


        //post
        public Usuario? agregar(MiBilleteraVirtualContext db, Usuario usuario)
        {
            db.Usuario.Add(usuario);
            db.SaveChanges();
            return usuario;
        }


        //put
        public Usuario? modificar(MiBilleteraVirtualContext db, int id, string? Nombre, string? Apellido, long? Cuil, string? NombreUsuario, string? Email, string? Contraseña, int? IdLocalidad)
        {
            Usuario? usuario = db.Usuario.FirstOrDefault(a => a.IdUsuario == id);
            usuario.Nombre = Nombre;
            usuario.Apellido = Apellido;
            usuario.Cuil = Cuil;
            usuario.Contraseña = Contraseña;
            usuario.NombreUsuario = NombreUsuario;
            usuario.Email = Email;
            usuario.IdLocalidad = IdLocalidad;

           
            db.SaveChanges();
            return usuario;
        }

        //Delete
        public void eliminar(MiBilleteraVirtualContext db, int id)
        {
            Usuario? usuario = db.Usuario.FirstOrDefault(x => x.IdUsuario == id);

            db.Remove(usuario);
            db.SaveChanges();

        }

        //Get all
        public void listar(MiBilleteraVirtualContext db)
        {
            db.Usuario.ToList();

        }
    }
}
