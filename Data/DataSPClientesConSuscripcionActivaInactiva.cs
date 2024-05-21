using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataSPClientesConSuscripcionActivaInactiva : IData<SPClientesConSuscripcionActivaInactiva_Result>
    {
        XboxGamePassEntities _context;
        public DataSPClientesConSuscripcionActivaInactiva()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<SPClientesConSuscripcionActivaInactiva_Result> Listar()
        {
            return _context.SPClientesConSuscripcionActivaInactiva().ToList();
        }

        public void Insertar(SPClientesConSuscripcionActivaInactiva_Result entity)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(SPClientesConSuscripcionActivaInactiva_Result entity)
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

        public SPClientesConSuscripcionActivaInactiva_Result buscarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public SPClientesConSuscripcionActivaInactiva_Result buscarPorId(int id)
        {
            throw new NotImplementedException();
        }
        public List<SPClientesConSuscripcionActivaInactiva_Result> Listar(string xd)
        {
            return null;
        }



    }
}
