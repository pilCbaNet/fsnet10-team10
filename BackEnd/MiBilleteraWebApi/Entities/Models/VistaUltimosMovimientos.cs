
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class VistaUltimosMoviminetos
    {
        public DateTime? Fecha { get; set; }
        public int? Monto { get; set; }
        public int? Deposito { get; set; }
        public int? Extraccion { get; set; }

        public int? IdCuenta { get; set; }
    }
}
