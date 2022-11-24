using System;
using System.Collections.Generic;

namespace MiBilleteraWebApi.Models
{
    public partial class Localidades
    {
        public Localidades()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdLocalidad { get; set; }
        public string Localidad { get; set; } = null!;
        public string Domicilio { get; set; } = null!;
        public int IdProvincia { get; set; }

        public virtual Provincias IdProvinciaNavigation { get; set; } = null!;
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
