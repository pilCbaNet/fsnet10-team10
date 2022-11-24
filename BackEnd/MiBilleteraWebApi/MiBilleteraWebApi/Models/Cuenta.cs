using System;
using System.Collections.Generic;

namespace MiBilleteraWebApi.Models
{
    public partial class Cuenta
    {
        public Cuenta()
        {
            Operacions = new HashSet<Operacion>();
        }

        public int IdCuenta { get; set; }
        public double? Saldo { get; set; }
        public string? Cvu { get; set; }
        public bool? Habilitado { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
        public virtual ICollection<Operacion> Operacions { get; set; }
    }
}
