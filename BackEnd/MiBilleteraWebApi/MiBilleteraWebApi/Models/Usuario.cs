using System;
using System.Collections.Generic;

namespace MiBilleteraWebApi.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Moneda = new HashSet<Moneda>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Cuil { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public int IdLocalidad { get; set; }
        public DateTime FechaNac { get; set; }

        public virtual Localidades IdLocalidadNavigation { get; set; } = null!;
        public virtual ICollection<Moneda> Moneda { get; set; }
    }
}
