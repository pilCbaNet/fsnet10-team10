//using Entities;
//using MiBilleteraWebApi.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Negocio
//{
//    public class DepositoExtraccion
//    {
//        public List<Operacion> esDeposito(int idOperacion, MiBilleteraVirtualContext db)
//        {
//            List<Operacion> depostio;
//            depostio = db.Operacion.Where(x => x.IdOperacion == idOperacion && x.Deposito.HasValue).ToList();
//            return depostio;
//        }
        

//        public void Depositar(Cuenta cuenta, Operacion operacion, MiBilleteraVirtualContext db)
//        {
//            if (!esDeposito(cuenta, operacion))
//            {
//                return;
//            }
//            else
//            {
//                db.Operacion.Where(x => x.IdCuenta == cuenta.IdCuenta).Add
//            }
//        }
//    }
//}
