using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataPago: IData<Pago>
    {
        XboxGamePassEntities _context;
        public DataPago()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        #region Métodos de Inserción/Actualización/Eliminación


        public void Insertar(Pago pago)
        {
            pago.Pago_LogicalDelete = false;
            pago.Pago_Codigo = null;
            _context.Pagos.Add(pago);
            _context.SaveChanges();
        }

        public void Actualizar(Pago pago)
        {
            Pago pagoActual = buscarPorId(pago.Pago_ID);
            pagoActual.Cli_Cedula = pago.Cli_Cedula;
            pagoActual.Sus_ID = pago.Sus_ID ?? pago.Sus_ID;
            pagoActual.Pago_Monto = pago.Pago_Monto ?? pago.Pago_Monto;
            pagoActual.Pago_Fecha = pago.Pago_Fecha ?? pago.Pago_Fecha;
            pagoActual.Pago_Estado = pago.Pago_Estado ?? pago.Pago_Estado;
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            Pago pagoActual = buscarPorId(id);
            if (pagoActual != null)
            {
                pagoActual.Pago_LogicalDelete = true;
                _context.SaveChanges();
            }
        }


        #endregion

        #region Métodos de Seleccion/Lectura

        public List<Pago> Listar()
        {
            return _context.Pagos.Where(p =>p.Pago_LogicalDelete == false).ToList();
        }

        public Pago buscarPorId(int id)
        {
            return _context.Pagos.Where(p => p.Pago_ID == id && p.Pago_LogicalDelete == false).FirstOrDefault();
        }
        public Pago buscarPorCodigo(string codigo)
        {
            return _context.Pagos.Where(p => p.Pago_Codigo == codigo && p.Pago_LogicalDelete == false).FirstOrDefault();
        }
        #endregion

        #region Metodos no implementados (sobrecargados)
        public Pago buscarPorId(string id)
        {
            return null;
        }

        public List<Pago> Listar(string id)
        {
            return null;
        }

        public void Eliminar(string id)
        {
            return;
        }

        #endregion


    }
}
