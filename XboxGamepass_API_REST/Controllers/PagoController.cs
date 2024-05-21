using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Logic;
using DataAccess;
namespace XboxGamepass_API_REST.Controllers
{
    public class PagoController : ApiController
    {
        LogicPago _context = new LogicPago();

        // GET: api/Pago
        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<Pago> Listar()
        {
            return _context.Listar();
        }

        //GET: api/Pago/buscarPorId/5
        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public Pago Listar(int id)
        {
            return _context.buscarPorId(id);
        }

        // POST: api/Pago/Insertar
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Insertar(Pago pago)
        {
            _context.Insertar(pago);
        }

        // PUT: api/Pago/Actualizar
        [HttpPut]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Actualizar(Pago pago)
        {
            _context.Actualizar(pago);
        }

        // DELETE: api/Pago/Eliminar/5
        [HttpDelete]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Eliminar(int id)
        {
            _context.Eliminar(id);
        }

    }
}
