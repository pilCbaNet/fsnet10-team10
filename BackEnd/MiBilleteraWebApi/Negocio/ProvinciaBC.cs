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
    public class ProvinciaBC
    {

        //get by id
        public Provincia? ObtenerProvincia(MiBilleteraVirtualContext db, int id)
        {
            return db.Provincia./*Include(a => a.Localidad)*//*.*/FirstOrDefault(a => a.Idprovincia == id);
        }


        //post
        public Provincia agregarProvincia(MiBilleteraVirtualContext db, Provincia provincia)
        {
            db.Provincia.Add(provincia);
            db.SaveChanges();
            return provincia;
        }


        //put
        public Provincia? modificar(MiBilleteraVirtualContext db, int id, string NombreProvincia)
        {
            Provincia? provincia = db.Provincia.FirstOrDefault(a => a.Idprovincia == id);
            provincia.NombreProvincia = NombreProvincia;
            db.SaveChanges();
            return provincia;
        }


        //Delete
        public void eliminarProvincia(MiBilleteraVirtualContext db, int id)
        {
            Provincia? provincia = db.Provincia.FirstOrDefault(x => x.Idprovincia == id);
            db.Remove(provincia);
            db.SaveChanges();

        }

        //Get all
        public void listarProvincias(MiBilleteraVirtualContext db)
        {
            db.Provincia.ToList();

        }


    }
}
