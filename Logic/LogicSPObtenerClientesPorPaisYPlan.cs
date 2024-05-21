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
    public class LogicSPObtenerClientesPorPaisYPlan
    {
        cacheGeneral<SPObtenerClientesPorPaisYPlan_Result, DataSPObtenerClientesPorPaisYPlan> cache = new cacheGeneral<SPObtenerClientesPorPaisYPlan_Result, DataSPObtenerClientesPorPaisYPlan>();

        public List<SPObtenerClientesPorPaisYPlan_Result> Listar()
        {
            return cache.Listar();
        }
    }
}
