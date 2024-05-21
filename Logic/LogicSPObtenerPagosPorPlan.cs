using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache;
using Data;
using DataAccess;
namespace Logic
{
    public class LogicSPObtenerPagosPorPlan
    {
        DataSPObtenerPagosPorPlan data = new DataSPObtenerPagosPorPlan();
        public SPObtenerPagosPorPlan_Result buscarPorId(string nombrePlan)
        {
            return data.buscarPorId(nombrePlan);
        }
    }
}
