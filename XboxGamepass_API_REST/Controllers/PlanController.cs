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
    public class PlanController : ApiController
    {
        LogicPlan _context = new LogicPlan();

        // GET: api/Plan/Listar
        [HttpGet]
        public List<Plan> Listar()
        {
            return _context.Listar();
        }

        //GET: api/Plan/buscarPorId/5
        [HttpGet]
        public Plan Listar(int id)
        {
            return _context.buscarPorId(id);
        }

        // POST: api/Plan/Insertar
        [HttpPost]
        public void Insertar(Plan plan)
        {
            _context.Insertar(plan);
        }

        // PUT: api/Plan/Actualizar
        [HttpPut]
        public void Actualizar(Plan plan)
        {
            _context.Actualizar(plan);
        }

        // DELETE: api/Plan/Eliminar/5
        [HttpDelete]
        public void Eliminar(int id)
        {
            _context.Eliminar(id);
        }
    }
}
