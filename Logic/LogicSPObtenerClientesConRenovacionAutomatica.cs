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
    public class LogicSPObtenerClientesConRenovacionAutomatica
    {
        cacheGeneral<SPObtenerClientesConRenovacionAutomatica_Result, DataSPObtenerClientesConRenovacionAutomatica> cache = new cacheGeneral<SPObtenerClientesConRenovacionAutomatica_Result, DataSPObtenerClientesConRenovacionAutomatica>();

        public List<SPObtenerClientesConRenovacionAutomatica_Result> Listar()
        {
            return cache.Listar();
        }
    }
}
