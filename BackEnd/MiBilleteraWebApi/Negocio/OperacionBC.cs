using Entities;
using MiBilleteraWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class OperacionBC
    {
        //get by id
        public Operacion? Obtener(MiBilleteraVirtualContext db, int id)
        {
            return db.Operacion.FirstOrDefault(a => a.IdOperacion == id);
        }


        //post
        public Operacion agregar(MiBilleteraVirtualContext db, Operacion operacion)
        {
            db.Operacion.Add(operacion);
            db.SaveChanges();
            return operacion;
        }


        //put
        public Operacion? modificar(MiBilleteraVirtualContext db, int id, DateTime? Fecha, double? Monto, bool? Deposito, bool? Extraccion, int? IdCuenta)
        {
            Operacion? operacion = db.Operacion.FirstOrDefault(a => a.IdOperacion == id);
            
            operacion.Fecha = Fecha ;
            operacion.Monto = Monto;
            operacion.Deposito = Deposito;
            operacion.Extraccion = Extraccion;
            operacion.IdCuenta = IdCuenta;
            db.SaveChanges();
            return operacion;
        }


        //Delete
        public void eliminar(MiBilleteraVirtualContext db, int id)
        {
            Operacion? operacion = db.Operacion.FirstOrDefault(x => x.IdOperacion == id);

            db.Remove(operacion);
            db.SaveChanges();

        }

        //Get all
        public void listar(MiBilleteraVirtualContext db)
        {
            db.Operacion.ToList();

        }
    }
}
