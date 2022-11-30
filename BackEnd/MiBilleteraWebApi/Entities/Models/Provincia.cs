using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Provincia
    {
        public Provincia()
        {
            Localidad = new HashSet<Localidad>();
        }

        public int Idprovincia { get; set; }
        public string? Provincia1 { get; set; }

        public virtual ICollection<Localidad> Localidad { get; set; }
    }
}
