using System;
using System.Collections.Generic;

namespace MiBilleteraWebApi.Models
{
    public partial class Cuenta
    {
        public Cuenta()
        {
            Operaciones = new HashSet<Operaciones>();
        }

        public int IdCuenta { get; set; }
        public double Saldo { get; set; }
        public string Cvu { get; set; } = null!;
        public bool Habilitado { get; set; }
        public int? IdUsuario { get; set; }

        public virtual ICollection<Operaciones> Operaciones { get; set; }
    }
}
