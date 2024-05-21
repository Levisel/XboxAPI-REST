using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Cache;
using Data;
using DataAccess;

namespace Logic
{
    public class LogicPago
    {
        cacheGeneral<Pago, DataPago> cache = new cacheGeneral<Pago, DataPago>();
        DataPago data = new DataPago();

        #region Métodos de Inserción/Actualización/Eliminación

        public void Insertar(Pago pago)
        {
            cache.Insertar(pago);
        }

        public void Actualizar(Pago pago)
        {
            cache.Actualizar(pago);
        }

        public void Eliminar(int id)
        {
            cache.Eliminar(id);
        }


        #endregion

        #region Métodos de Seleccion/Lectura

        public List<Pago> Listar()
        {
            return data.Listar();
        }

        public Pago buscarPorId(int id)
        {
            return cache.Listar().Where(p => p.Pago_ID == id).FirstOrDefault();
        }

        public Pago buscarPorCodigo(string codigo)
        {
            return cache.Listar().Where(p => p.Pago_Codigo == codigo).FirstOrDefault();
        }

        #endregion

    }
}
