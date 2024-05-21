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
    public class ClienteController : ApiController
    {
        LogicCliente _context = new LogicCliente();

        // GET: api/Cliente/Listar
        [HttpGet]
        public List<Cliente> Listar()
        {
            return _context.Listar();
        }

        // GET: api/Cliente/buscarPorId/5
        [HttpGet]
        public Cliente Listar(string id)
        {
            return _context.buscarPorId(id);
        }

        // POST: api/Cliente/Insertar
        [HttpPost]
        public void Insertar(Cliente cliente)
        {
            _context.Insertar(cliente);    
        }

        // PUT: api/Cliente/Actualizar
        [HttpPut]

        public void Actualizar(Cliente cliente)
        {
            _context.Actualizar(cliente);
        }

        // DELETE: api/Cliente/Eliminar/5
        [HttpDelete]
        public void Eliminar(string id)
        {
            _context.Eliminar(id);
        }
    }
}
