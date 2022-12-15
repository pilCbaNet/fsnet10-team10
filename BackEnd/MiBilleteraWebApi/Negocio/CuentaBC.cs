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
        public bool Deposito(MiBilleteraVirtualContext db, int id, int? cantidad, long? Cvu) // sauqe el bool?
        {
            bool exito = false;
            Cuenta? cuenta = db.Cuenta.FirstOrDefault(a => a.IdCuenta == id);
            //Operacion operacionPivot = db.Operacion.Last(Operacion);
            //int ultimoID = db.Operacion.Max(x => x.IdOperacion);
            int idPivot = db.Operacion.OrderByDescending(x => x.IdOperacion).First().IdOperacion;
            if (cuenta is not null && cuenta.Habilitado == true)
            {
                cuenta.Saldo += cantidad;
                cuenta.Cvu = Cvu;
                exito = true;
            }
            //cuenta.Habilitado = Habilitado; se puede sacar
            if (exito == true)
            {
                Operacion? deposito = new Operacion();
                deposito.IdOperacion = idPivot + 1;
                deposito.IdCuenta = id;
                deposito.Fecha = DateTime.Now;
                deposito.Monto = cantidad;
                deposito.Deposito = true;
                deposito.Extraccion = false;
                new OperacionBC().agregar(db, deposito);
            }

            db.SaveChanges();
            return exito;
        }
        public bool Extraccion(MiBilleteraVirtualContext db, int id, int? cantidad, long? Cvu)
        {
            bool exito = false;
            Cuenta? cuenta = db.Cuenta.FirstOrDefault(a => a.IdCuenta == id);
            int idPivot = db.Operacion.OrderByDescending(x => x.IdOperacion).First().IdOperacion;
            if (cuenta is not null && cuenta.Habilitado == true && cuenta.Saldo >= cantidad )
            {
                cuenta.Saldo -= cantidad;
                cuenta.Cvu = Cvu;
                exito = true;
            }
            if (exito == true)
            {
                Operacion deposito = new Operacion();
                deposito.IdOperacion = idPivot + 1;
                deposito.IdCuenta = id;
                deposito.Fecha = DateTime.Now;
                deposito.Monto = cantidad;
                deposito.Deposito = false;
                deposito.Extraccion = true;
                new OperacionBC().agregar(db, deposito);
            }

            db.SaveChanges();
            return exito;
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

