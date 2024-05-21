using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cache
{
    public class cacheGeneral<TEntidad, TDatos> where TDatos : IData<TEntidad>, new() where TEntidad : class
    {
        private static List<TEntidad> cache;
        private TDatos datos = new TDatos();

        private void CargarDesdeBD()
        {
            cache = new List<TEntidad>();
            cache = datos.Listar();
        }

        public List<TEntidad> Listar()
        {
            CargarDesdeBD();
            return cache;
        }

        public void Insertar(TEntidad entidad)
        {
            datos.Insertar(entidad);
            CargarDesdeBD();
        }

        public void Actualizar(TEntidad entidad)
        {
            datos.Actualizar(entidad);
            CargarDesdeBD();
        }

        public void Eliminar(string id) 
        {     
            datos.Eliminar(id);
            CargarDesdeBD();
        }

        public void Eliminar(int id)
        {
            datos.Eliminar(id);
            CargarDesdeBD();
        }

    }
}