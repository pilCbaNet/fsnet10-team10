using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class CuentaDto
    {
        public int IdCuenta { get; set; }
        public double? Saldo { get; set; }
        public long? Cvu { get; set; }
        public bool? Habilitado { get; set; }
        public int? IdUsuario { get; set; }
    }
}
