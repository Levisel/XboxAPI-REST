using DataAccess.DTO;
using Logic;
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
    public class ServicioPXGController : ApiController
    {
        LogicIntegrationService _context = new LogicIntegrationService();

        [HttpGet]
        // GET: api/ServicioPXG/mostrarServiciosPXG
        public List<mostrarServiciosDTO> mostrarServiciosPXG()
        {
            return _context.mostrarServiciosPXG();
        }

        [HttpGet]
        // GET: api/ServicioPXG/mostrarPagosPXG/1721933545
        public List<mostrarPagosDTO> mostrarPagosPXG(string id) //cedula
        {
            return _context.mostrarPagosPXG(id);
        }

        [HttpGet]
        // GET: api/ServicioPXG/actualizarEstadoPXG/PXG102
        public bool actualizarEstadoPXG (string id) //codigo de pago
        {
            return _context.actualizarEstadoPXG(id);
        }

        
    }
}
