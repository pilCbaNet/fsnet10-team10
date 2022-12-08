using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Cuenta
    {
        //public Cuenta()
        //{
        //    Operacion = new HashSet<Operacion>();
        //}

        public int IdCuenta { get; set; }
        public double? Saldo { get; set; }
        public long? Cvu { get; set; }
        public bool? Habilitado { get; set; }
        public int? IdUsuario { get; set; }

        //public virtual Usuario? IdUsuarioNavigation { get; set; }
        //public virtual ICollection<Operacion> Operacion { get; set; }
    }
}
