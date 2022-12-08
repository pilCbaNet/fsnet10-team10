using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Operacion
    {
        public int IdOperacion { get; set; }
        public DateTime? Fecha { get; set; }
        public double? Monto { get; set; }
        public bool? Deposito { get; set; }
        public bool? Extraccion { get; set; }
        public int? IdCuenta { get; set; }

        //public virtual Cuenta? IdCuentaNavigation { get; set; }
    }
}
