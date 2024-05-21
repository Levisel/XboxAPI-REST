using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache;
using Data;
using DataAccess;

namespace Logic
{
    public class LogicSuscripcion
    {
        cacheGeneral<Suscripcion, DataSuscripcion> cache = new cacheGeneral<Suscripcion, DataSuscripcion>();

        #region Métodos de Inserción/Actualización/Eliminación

        public void Insertar(Suscripcion suscripcion)
        {
            cache.Insertar(suscripcion);
        }

        public void Actualizar(Suscripcion suscripcion)
        {
            cache.Actualizar(suscripcion);
        }

        public void Eliminar(string id)
        {
            cache.Eliminar(id);
        }



        #endregion

        #region Métodos de Seleccion/Lectura

        public List<Suscripcion> Listar()
        {
            return cache.Listar();
        }

        public Suscripcion buscarPorId(string id)
        {
            return cache.Listar().Where(sus => sus.Sus_ID == id).FirstOrDefault();
        }

        #endregion

    }
}
