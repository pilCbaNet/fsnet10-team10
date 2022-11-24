using System;
using System.Collections.Generic;

namespace MiBilleteraWebApi.Models
{
    public partial class Provincias
    {
        public Provincias()
        {
            Localidades = new HashSet<Localidades>();
        }

        public int IdProvincia { get; set; }
        //public string? Provincia { get; set; }

        public string? Provincia { get; set; }

        public virtual ICollection<Localidades> Localidades { get; set; }
    }
}
