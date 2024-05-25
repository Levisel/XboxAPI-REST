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
        DataIntegrationService pagosDTO = new DataIntegrationService();
        mostrarServiciosDTO serviciosDTO = new mostrarServiciosDTO();

        public List<mostrarServiciosDTO> mostrarServiciosPXG()
        {
            List<mostrarServiciosDTO> lstServicios = new List<mostrarServiciosDTO>();
            serviciosDTO.Nombre = "Xbox Game Pass";
            serviciosDTO.Descripcion = "Servicio para pagar la suscripción de XboxGamePass";
            lstServicios.Add(serviciosDTO);
            return lstServicios;
        }


        public List<mostrarPagosDTO> mostrarPagosPXG(string CI)
        {
            return pagosDTO.mostrarPagosPXG(CI);
        }

        public bool actualizarEstadoPXG(string codPago)
        {
            return pagosDTO.actualizarEstadoPXG(codPago);
        }

    }
}
