using Entities;
using MiBilleteraWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{

    public class CuentaBC 
    {
        //get by id
        public Cuenta? Obtener(MiBilleteraVirtualContext db, int id)
        {
            return db.Cuenta.FirstOrDefault(a => a.IdCuenta == id);
        }


        //post
        public Cuenta agregar(MiBilleteraVirtualContext db, Cuenta cuenta)
        {
            db.Cuenta.Add(cuenta);
            db.SaveChanges();
            return cuenta;
        }


        //put
        public Cuenta? modificar(MiBilleteraVirtualContext db, int id, Double? Saldo, long? Cvu, bool? Habilitado, int? IdUsuario)
        {
            Cuenta? cuenta = db.Cuenta.FirstOrDefault(a => a.IdCuenta == id);

            cuenta.IdUsuario = IdUsuario;
            cuenta.Saldo = Saldo;
            cuenta.Cvu = Cvu;
            cuenta.Habilitado= Habilitado;  

            db.SaveChanges();
            return cuenta;
        }



        //Delete
        public void eliminar(MiBilleteraVirtualContext db, int id)
        {
            Cuenta? cuenta = db.Cuenta.FirstOrDefault(x => x.IdCuenta == id);

            db.Remove(cuenta);
            db.SaveChanges();

        }

        //Get all
        public void listar(MiBilleteraVirtualContext db)
        {
            db.Cuenta.ToList();

        }
    }


}

