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
    public class LogicSPClientesConSuscripcionActivaInactiva
    {
        cacheGeneral<SPClientesConSuscripcionActivaInactiva_Result, DataSPClientesConSuscripcionActivaInactiva> cache = new cacheGeneral<SPClientesConSuscripcionActivaInactiva_Result, DataSPClientesConSuscripcionActivaInactiva>();

        public List<SPClientesConSuscripcionActivaInactiva_Result> Listar()
        {
            return cache.Listar();
        }
    }

}
