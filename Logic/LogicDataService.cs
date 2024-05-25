using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicDataService
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public LogicDataService()
        {
            Nombre = "Xbox Game Pass";
            Descripcion = "Servicio para pagar la suscripción de XboxGamePass";
        }
    }
}
