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
    public class PlanController : ApiController
    {
        LogicPlan _context = new LogicPlan();

        // GET: api/Plan/Listar
        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<Plan> Listar()
        {
            return _context.Listar();
        }

        //GET: api/Plan/buscarPorId/5
        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public Plan Listar(int id)
        {
            return _context.buscarPorId(id);
        }

        // POST: api/Plan/Insertar
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Insertar(Plan plan)
        {
            _context.Insertar(plan);
        }

        // PUT: api/Plan/Actualizar
        [HttpPut]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Actualizar(Plan plan)
        {
            _context.Actualizar(plan);
        }

        // DELETE: api/Plan/Eliminar/5
        [HttpDelete]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Eliminar(int id)
        {
            _context.Eliminar(id);
        }
    }
}
