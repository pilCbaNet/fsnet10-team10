using System;
using System.Collections.Generic;

namespace MiBilleteraWebApi.Models
{
    public partial class Moneda
    {
        public int IdMoneda { get; set; }
        public double Monto { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
