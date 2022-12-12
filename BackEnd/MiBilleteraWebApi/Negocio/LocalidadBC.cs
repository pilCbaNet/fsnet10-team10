using Entities;
using MiBilleteraWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LocalidadBC
    {
        //get by id
        public Localidad? Obtener(MiBilleteraVirtualContext db, int id)
        {
            return db.Localidad.FirstOrDefault(a => a.IdLocalidad == id);
        }


        //post
        public Localidad agregar(MiBilleteraVirtualContext db, Localidad localidad)
        {
            db.Localidad.Add(localidad);
            db.SaveChanges();
            return localidad;
        }


        //put
        public Localidad? modificar(MiBilleteraVirtualContext db, int id, string? NombreLocalidad, string? Domicilio, int? idProvincia)
        {
            Localidad? localidad = db.Localidad.FirstOrDefault(a => a.IdLocalidad == id);
            localidad.NombreLocalidad = NombreLocalidad;
            localidad.IdProvincia = idProvincia;
            localidad.Domicilio = Domicilio;
           
            db.SaveChanges();
            return localidad;
        }


        //Delete
        public void eliminar(MiBilleteraVirtualContext db, int id)
        {
            Localidad? localidad = db.Localidad.FirstOrDefault(x => x.IdLocalidad == id);

            db.Remove(localidad);
            db.SaveChanges();

        }

        //Get all
        public void listar(MiBilleteraVirtualContext db)
        {
            db.Localidad.ToList();

        }

    }
}
