using Logic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
namespace XboxGamepass_API_REST.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SPController : ApiController
    {
        LogicSPClientesConSuscripcionActivaInactiva logicSPClientesConSuscripcionActivaInactiva = new LogicSPClientesConSuscripcionActivaInactiva();
        LogicSPObtenerClientesConRenovacionAutomatica logicSPObtenerClientesConRenovacionAutomatica = new LogicSPObtenerClientesConRenovacionAutomatica();
        LogicSPObtenerClientesPorPaisYPlan logicSPObtenerClientesPorPaisYPlan = new LogicSPObtenerClientesPorPaisYPlan();
        LogicSPObtenerClientesPorPlataforma logicSPObtenerClientesPorPlataforma = new LogicSPObtenerClientesPorPlataforma();
        LogicSPObtenerNumeroClientesPorPais logicSPObtenerNumeroClientesPorPais = new LogicSPObtenerNumeroClientesPorPais();


        // GET: api/SP/ListarClientesConSuscripcionActivaInactiva
        [HttpGet]
        public List<SPClientesConSuscripcionActivaInactiva_Result> ListarClientesConSuscripcionActivaInactiva()
        {
            return logicSPClientesConSuscripcionActivaInactiva.Listar();
        }

        // GET: api/SP/ListarClientesConRenovacionAutomatica
        [HttpGet]
        public List<SPObtenerClientesConRenovacionAutomatica_Result> ListarClientesConRenovacionAutomatica()
        {
            return logicSPObtenerClientesConRenovacionAutomatica.Listar();
        }

        // GET: api/SP/ListarClientesPorPaisYPlan
        [HttpGet]
        public List<SPObtenerClientesPorPaisYPlan_Result> ListarClientesPorPaisYPlan()
        {
            return logicSPObtenerClientesPorPaisYPlan.Listar();
        }

        // GET: api/SP/ListarClientesPorPlataforma
        [HttpGet]
        public List<SPObtenerClientesPorPlataforma_Result> ListarClientesPorPlataforma()
        {
            return logicSPObtenerClientesPorPlataforma.Listar();
        }

        // GET: api/SP/ListarNumeroClientesPorPais
        [HttpGet]
        public List<SPObtenerNumeroClientesPorPais_Result> ListarNumeroClientesPorPais()
        {
            return logicSPObtenerNumeroClientesPorPais.Listar();
        }
    }
}
