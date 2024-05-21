using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Data
{
    public class DataSPObtenerNumeroClientesPorPais: IData<SPObtenerNumeroClientesPorPais_Result>
    {
        XboxGamePassEntities _context;

        public DataSPObtenerNumeroClientesPorPais()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<SPObtenerNumeroClientesPorPais_Result> Listar()
        {
            return _context.SPObtenerNumeroClientesPorPais().ToList();
        }

        public void Insertar(SPObtenerNumeroClientesPorPais_Result entity)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(SPObtenerNumeroClientesPorPais_Result entity)
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

        public SPObtenerNumeroClientesPorPais_Result buscarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public SPObtenerNumeroClientesPorPais_Result buscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<SPObtenerNumeroClientesPorPais_Result> Listar(string valor)
        {
            return null;
        }

    }
}
