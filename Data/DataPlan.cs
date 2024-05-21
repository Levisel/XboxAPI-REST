using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataPlan: IData<Plan>
    {
        XboxGamePassEntities _context;
        public DataPlan()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        #region Métodos de Inserción/Actualización/Eliminación


        public void Insertar(Plan plan)
        {
            plan.Plan_LogicalDelete = false;
            _context.Plans.Add(plan);
            _context.SaveChanges();
        }

        public void Actualizar(Plan plan)
        {
            Plan planActual = buscarPorId(plan.Plan_ID);
            planActual.Plan_Nombre = plan.Plan_Nombre ?? plan.Plan_Nombre;
            planActual.Plan_Duracion = plan.Plan_Duracion ?? plan.Plan_Duracion;
            planActual.Plan_Precio = plan.Plan_Precio ?? plan.Plan_Precio;
            planActual.Plan_Plataforma = plan.Plan_Plataforma ?? plan.Plan_Plataforma;
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            Plan planActual = buscarPorId(id);
            if (planActual != null)
            {
                planActual.Plan_LogicalDelete = true;
                _context.SaveChanges();
            }
        }


        #endregion

        #region Métodos de Seleccion/Lectura

        public List<Plan> Listar()
        {
            return _context.Plans.Where(pl => pl.Plan_LogicalDelete == false).ToList();
        }

        public Plan buscarPorId(int id)
        {
            return _context.Plans.Where(pl => pl.Plan_ID == id && pl.Plan_LogicalDelete == false).FirstOrDefault();
        }
        #endregion

        #region Metodos no implementados (sobrecargados)
        public Plan buscarPorId(string id)
        {
            return null;
        }

        public List<Plan> Listar(string id)
        {
            return null;
        }

        public void Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        #endregion




    }
}
