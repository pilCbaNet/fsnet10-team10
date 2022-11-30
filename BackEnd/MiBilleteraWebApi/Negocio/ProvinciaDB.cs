using Entities;
using MiBilleteraWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProvinciaDB
    {

        public Provincia? ObtenerProvincia(MiBilleteraVirtualContext db, int id)
        {
            return db.Provincia.Include(a => a.Localidad).FirstOrDefault(a => a.Idprovincia == id);
        }
    }
}
