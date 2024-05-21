using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Data
{
    public class DataSuscripcion: IData<Suscripcion>
    {
        XboxGamePassEntities _context;
        public DataSuscripcion()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        #region Métodos de Inserción/Actualización/Eliminación

        public void Insertar(Suscripcion suscripcion)
        {
            suscripcion.Sus_LogicalDelete = false;
            _context.Suscripcions.Add(suscripcion);
            _context.SaveChanges();
        }

        public void Actualizar(Suscripcion suscripcion)
        {
            Suscripcion suscripcionActual = buscarPorId(suscripcion.Sus_ID);
            suscripcionActual.Plan_ID = suscripcion.Plan_ID;
            suscripcionActual.Sus_StartDate = suscripcion.Sus_StartDate ?? suscripcion.Sus_StartDate;
            suscripcionActual.Sus_EndDate = suscripcion.Sus_EndDate ?? suscripcion.Sus_EndDate;
            suscripcionActual.Sus_Estado = suscripcion.Sus_Estado ?? suscripcion.Sus_Estado;
            suscripcionActual.Sus_RenovacionAuto = suscripcion.Sus_RenovacionAuto ?? suscripcion.Sus_RenovacionAuto;
            _context.SaveChanges();
        }

        public void Eliminar(string id)
        {
            Suscripcion suscripcionActual = buscarPorId(id);
            if (suscripcionActual != null)
            {
                suscripcionActual.Sus_LogicalDelete = true;
                _context.SaveChanges();
            }
        }
        #endregion

        #region Métodos de Seleccion/Lectura

        public List<Suscripcion> Listar()
        {
            return _context.Suscripcions.Where(sus => sus.Sus_LogicalDelete == false).ToList();
        }

        public Suscripcion buscarPorId(string id)
        {
            return _context.Suscripcions.Where(sus => sus.Sus_ID == id && sus.Sus_LogicalDelete == false).FirstOrDefault();
        }

        #endregion

        #region Metodos no implementados (sobrecargados)
        public Suscripcion buscarPorId(int id)
        {
            return null;
        }

        public List<Suscripcion> Listar(string id)
        {
            return null;
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        #endregion





    }
}
