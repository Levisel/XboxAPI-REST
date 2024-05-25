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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PagoController : ApiController
    {
        LogicPago _context = new LogicPago();

        // GET: api/Pago
        [HttpGet]
        public List<Pago> Listar()
        {
            return _context.Listar();
        }

        //GET: api/Pago/buscarPorId/5
        [HttpGet]
        public Pago Listar(int id)
        {
            return _context.buscarPorId(id);
        }

        // POST: api/Pago/Insertar
        [HttpPost]
        public void Insertar(Pago pago)
        {
            _context.Insertar(pago);
        }

        // PUT: api/Pago/Actualizar
        [HttpPut]
        public void Actualizar(Pago pago)
        {
            _context.Actualizar(pago);
        }

        // DELETE: api/Pago/Eliminar/5
        [HttpDelete]
        public void Eliminar(int id)
        {
            _context.Eliminar(id);
        }

    }
}
