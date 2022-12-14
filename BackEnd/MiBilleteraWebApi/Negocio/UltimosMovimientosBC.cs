

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MiBilleteraWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Negocio;


namespace Negocio
{
    public class UltimosMovimientosBC
    {

        public List<Operacion> ObtenerOperacion(MiBilleteraVirtualContext db, int idCuenta)
        {
            var listOperacion = db.Operacion.Where(x => x.IdCuenta == idCuenta).ToList();
            List<Operacion> movimientos = new List<Operacion>();
            movimientos = listOperacion.OrderByDescending(x => x.Fecha).ToList(); ;
            return movimientos.OrderByDescending(x => x.Fecha).ToList();
        }
        public List<Operacion> ObtenerOperacion(MiBilleteraVirtualContext db, int idCuenta, int cant)
        {
            var listOperacion = db.Operacion.Where(x => x.IdCuenta == idCuenta).ToList();
            List<Operacion> movimientos = new List<Operacion>();
            for (int i = listOperacion.Count; i > (listOperacion.Count - cant); i--)
            {
                movimientos.Add(listOperacion[i - 1]);
            }
            return movimientos.ToList();
        }
    }
}