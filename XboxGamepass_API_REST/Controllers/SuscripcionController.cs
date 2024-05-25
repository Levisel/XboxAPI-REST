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
    public class SuscripcionController : ApiController
    {
        LogicSuscripcion _context = new LogicSuscripcion();

        // GET: api/Suscripcion/Listar
        [HttpGet]
        public List<Suscripcion> Listar()
        {
            return _context.Listar();
        }

        // GET: api/Suscripcion/buscarPorId/5
        [HttpGet]
        public Suscripcion Listar(string id)
        {
            return _context.buscarPorId(id);
        }

        // POST: api/Suscripcion/Insertar
        [HttpPost]
        public void Insertar(Suscripcion suscripcion)
        {
            _context.Insertar(suscripcion);
        }

        // PUT: api/Suscripcion/Actualizar
        [HttpPut]
        public void Actualizar(Suscripcion suscripcion)
        {
            _context.Actualizar(suscripcion);
        }

        // DELETE: api/Suscripcion/Eliminar/5
        [HttpDelete]
        public void Eliminar(string id)
        {
            _context.Eliminar(id);
        }
    }
}
