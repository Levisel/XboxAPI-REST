using DataAccess;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataIntegrationService
    {

        public List<mostrarPagosDTO> mostrarPagosPXG(string CI)
        {
            DataPago dataPago = new DataPago();
            List<Pago> pagos = dataPago.Listar().Where(p => p.Cli_Cedula.Equals(CI) && p.Pago_Estado.ToLower().Equals("pendiente")).ToList();
            List<mostrarPagosDTO> lstPagosPXG = new List<mostrarPagosDTO>();

            foreach (Pago pago in pagos)
            {
                mostrarPagosDTO mostrarPagosPXG = new mostrarPagosDTO();
                mostrarPagosPXG.codPago = pago.Pago_Codigo;
                mostrarPagosPXG.monto = (decimal) pago.Pago_Monto;
                lstPagosPXG.Add(mostrarPagosPXG);
            }
            return lstPagosPXG;
        }

        public bool actualizarEstadoPXG(string codPago)
        {
            bool actualizado = false;
            DataPago dataPago = new DataPago();
            Pago pago = dataPago.Listar().Where(p => p.Pago_Codigo.Equals(codPago)).FirstOrDefault();
            if(pago != null && pago.Pago_Estado.ToLower().Equals("pendiente"))
            {
                pago.Pago_Estado = "Pagado";
                dataPago.Actualizar(pago);
                actualizado = true;
            }
            else actualizado = false;
            return actualizado;
        }


    }
}
