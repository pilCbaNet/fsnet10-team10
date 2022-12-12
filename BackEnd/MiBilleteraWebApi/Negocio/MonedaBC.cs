using Entities;
using MiBilleteraWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MonedaBC
    {
        //get by id
        public Moneda? Obtener(MiBilleteraVirtualContext db, int id)
        {
            return db.Moneda.FirstOrDefault(a => a.IdMoneda == id);
        }


        //post
        public Moneda agregar(MiBilleteraVirtualContext db, Moneda moneda)
        {
            db.Moneda.Add(moneda);
            db.SaveChanges();
            return moneda;
        }


        //put
        public Moneda? modificar(MiBilleteraVirtualContext db, int id, double? Monto, string? Nombre, int? idUsuario)
        {
            Moneda? moneda = db.Moneda.FirstOrDefault(a => a.IdMoneda == id);
            moneda.idUsuario = idUsuario;
            moneda.Nombre = Nombre;
            moneda.Monto = Monto;

            db.SaveChanges();
            return moneda;
        }

        //Delete
        public void eliminar(MiBilleteraVirtualContext db, int id)
        {
            Moneda? moneda = db.Moneda.FirstOrDefault(x => x.IdMoneda == id);

            db.Remove(moneda);
            db.SaveChanges();

        }

        //Get all
        public void listar(MiBilleteraVirtualContext db)
        {
            db.Moneda.ToList();

        }
    }
}
