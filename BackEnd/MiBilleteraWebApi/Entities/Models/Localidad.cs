using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Localidad
    {
        public Localidad()
        {
            Usuarios = new HashSet<Usuario?>();
        }

        public int IdLocalidad { get; set; }
        public string? NombreLocalidad { get; set; }
        public string? Domicilio { get; set; }
        public int? IdProvincia { get; set; }

        public virtual Provincia? IdProvinciaNavigation { get; set; }
        public virtual ICollection<Usuario?> Usuarios { get; set; }

    }
}
