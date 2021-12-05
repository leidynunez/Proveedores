using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proveedores.Models
{
    public class recibos
    {
        public int ID { get; set; }
        public string Proveedor { get; set; }
        public int Monto { get; set; }
        public int Moneda { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

    }
}