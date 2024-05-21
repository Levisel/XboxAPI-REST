using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IData<T> where T : class
    {
        void Insertar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(string id);
        void Eliminar(int id);
        List<T> Listar();
        T buscarPorId(int id); //Para un ID tipo int
        T buscarPorId(string id); //Para un ID tipo string

    }
}
