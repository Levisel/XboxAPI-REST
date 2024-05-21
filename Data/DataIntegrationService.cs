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

        public List<MostrarPagosPXG> mostrarPagosPXG(string cedula)
        {
            DataPago dataPago = new DataPago();
            List<Pago> pagos = dataPago.Listar().Where(p => p.Cli_Cedula.Equals(cedula) && p.Pago_Estado.ToLower().Equals("pendiente")).ToList();
            List<MostrarPagosPXG> lstPagosPXG = new List<MostrarPagosPXG>();

            foreach (Pago pago in pagos)
            {
                MostrarPagosPXG mostrarPagosPXG = new MostrarPagosPXG();
                mostrarPagosPXG.cedula = pago.Cli_Cedula;
                mostrarPagosPXG.cod_pago = pago.Pago_Codigo;
                mostrarPagosPXG.monto = (decimal) pago.Pago_Monto;
                mostrarPagosPXG.nServicio = "PagoXboxGamePass";

                lstPagosPXG.Add(mostrarPagosPXG);
            }
            return lstPagosPXG;
        }

        public bool actualizarEstado(string codPago)
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
