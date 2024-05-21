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
    public class LogicSPObtenerClientesPorPlataforma
    {
        cacheGeneral<SPObtenerClientesPorPlataforma_Result, DataSPObtenerClientesPorPlataforma> cache = new cacheGeneral<SPObtenerClientesPorPlataforma_Result, DataSPObtenerClientesPorPlataforma>();

        public List<SPObtenerClientesPorPlataforma_Result> Listar()
        {
            return cache.Listar();
        }
    }
}
