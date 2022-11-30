using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Moneda
    {
        public int IdMoneda { get; set; }
        public double? Monto { get; set; }
        public string? Nombre { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
