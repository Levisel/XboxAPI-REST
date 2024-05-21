using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Data
{
    public class DataSPObtenerClientesConRenovacionAutomatica: IData<SPObtenerClientesConRenovacionAutomatica_Result>
    {
        XboxGamePassEntities _context;

        public DataSPObtenerClientesConRenovacionAutomatica()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<SPObtenerClientesConRenovacionAutomatica_Result> Listar()
        {
            return _context.SPObtenerClientesConRenovacionAutomatica().ToList();
        }

        public void Insertar(SPObtenerClientesConRenovacionAutomatica_Result entity)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(SPObtenerClientesConRenovacionAutomatica_Result entity)
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

        public SPObtenerClientesConRenovacionAutomatica_Result buscarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public SPObtenerClientesConRenovacionAutomatica_Result buscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<SPObtenerClientesConRenovacionAutomatica_Result> Listar(string valor)
        {
            return null;
        }


    }
}
