using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public partial class VistaUsuario
    {
        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public long? Cuil { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Email { get; set; }
        public string? Contraseña { get; set; }
        public int? IdLocalidad { get; set; }

    }
}
