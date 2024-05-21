using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Data
{
    public class DataSPObtenerClientesPorPaisYPlan : IData<SPObtenerClientesPorPaisYPlan_Result>
    {
        XboxGamePassEntities _context;

        public DataSPObtenerClientesPorPaisYPlan()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<SPObtenerClientesPorPaisYPlan_Result> Listar()
        {
            return _context.SPObtenerClientesPorPaisYPlan().ToList();
        }

        public void Insertar(SPObtenerClientesPorPaisYPlan_Result entity)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(SPObtenerClientesPorPaisYPlan_Result entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public SPObtenerClientesPorPaisYPlan_Result buscarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public SPObtenerClientesPorPaisYPlan_Result buscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<SPObtenerClientesPorPaisYPlan_Result> Listar(string valor)
        {
            return null;
        }

    }
}
