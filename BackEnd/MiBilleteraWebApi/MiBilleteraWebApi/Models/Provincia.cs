using System;
using System.Collections.Generic;

namespace MiBilleteraWebApi.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Localidads = new HashSet<Localidad>();
        }

        public int Idprovincia { get; set; }
        public string? Provincia1 { get; set; }

        public virtual ICollection<Localidad> Localidads { get; set; }
    }
}
