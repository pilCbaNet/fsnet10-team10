using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cuenta = new HashSet<Cuenta>();
            Moneda = new HashSet<Moneda>();
        }

        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Cuil { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Email { get; set; }
        public string? Contraseña { get; set; }
        public int? IdLocalidad { get; set; }

        public virtual Localidad? IdLocalidadNavigation { get; set; }
        public virtual ICollection<Cuenta> Cuenta { get; set; }
        public virtual ICollection<Moneda> Moneda { get; set; }
    }
}
