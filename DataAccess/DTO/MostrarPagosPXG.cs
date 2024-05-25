using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class MostrarPagosPXG
    {
        public string cedula { get; set; }
        public string cod_pago { get; set; }
        public decimal monto { get; set; }
        public string estado { get; set; }
        public string nServicio { get; set; }

    }
}
