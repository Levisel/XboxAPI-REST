using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Data
{
    public class DataSPObtenerClientesPorPlataforma: IData<SPObtenerClientesPorPlataforma_Result>
    {
        XboxGamePassEntities _context;

        public DataSPObtenerClientesPorPlataforma()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<SPObtenerClientesPorPlataforma_Result> Listar()
        {
            return _context.SPObtenerClientesPorPlataforma().ToList();
        }

        public void Insertar(SPObtenerClientesPorPlataforma_Result entity)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(SPObtenerClientesPorPlataforma_Result entity)
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

        public SPObtenerClientesPorPlataforma_Result buscarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public SPObtenerClientesPorPlataforma_Result buscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<SPObtenerClientesPorPlataforma_Result> Listar(string valor)
        {
            return null;
        }

    }
}
