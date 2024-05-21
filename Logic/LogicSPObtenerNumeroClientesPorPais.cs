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
    public class LogicSPObtenerNumeroClientesPorPais
    {
        cacheGeneral<SPObtenerNumeroClientesPorPais_Result, DataSPObtenerNumeroClientesPorPais> cache = new cacheGeneral<SPObtenerNumeroClientesPorPais_Result, DataSPObtenerNumeroClientesPorPais>();

        public List<SPObtenerNumeroClientesPorPais_Result> Listar()
        {
            return cache.Listar();
        }
    }
}
