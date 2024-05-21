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
    public class LogicPlan
    {
        cacheGeneral<Plan, DataPlan> cache = new cacheGeneral<Plan, DataPlan>();

        #region Métodos de Inserción/Actualización/Eliminación

        public void Insertar(Plan plan)
        {
            cache.Insertar(plan);
        }

        public void Actualizar(Plan plan)
        {
            cache.Actualizar(plan);
        }
        
        public void Eliminar(int id)
        {
            cache.Eliminar(id);
        }



        #endregion

        #region Métodos de Seleccion/Lectura

        public List<Plan> Listar()
        {
            return cache.Listar();
        }

        public Plan buscarPorId(int id)
        {
            return cache.Listar().Where(pl => pl.Plan_ID == id).FirstOrDefault();
        }

        #endregion

    }
}
