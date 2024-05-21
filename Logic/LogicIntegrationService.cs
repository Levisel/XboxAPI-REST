using Data;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicIntegrationService
    {
        DataIntegrationService _context = new DataIntegrationService();
        LogicDataService service = new LogicDataService();

        public LogicDataService mostrarServicio()
        {
            return service;
        }


        public List<MostrarPagosPXG> mostrarPagosPXG(string cedula)
        {
            return _context.mostrarPagosPXG(cedula);
        }

        public bool actualizarEstado(string codPago)
        {
            return _context.actualizarEstado(codPago);
        }

    }
}
