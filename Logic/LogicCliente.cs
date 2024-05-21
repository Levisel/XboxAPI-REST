
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
    public class LogicCliente
    {
        cacheGeneral<Cliente, DataCliente> cache = new cacheGeneral<Cliente, DataCliente>();

        #region Métodos de Inserción/Actualización/Eliminación

        public void Insertar(Cliente cliente)
        {
            cache.Insertar(cliente);
        }

        public void Actualizar(Cliente cliente)
        {
            cache.Actualizar(cliente);
        }

        public void Eliminar(string cedula)
        {
            cache.Eliminar(cedula);
        }

        #endregion

        #region Métodos de Seleccion/Lectura

        public List<Cliente> Listar()
        {
            return cache.Listar();
        }

        public Cliente buscarPorId(string id)
        {
            return cache.Listar().Where(cli => cli.Cli_Cedula == id).FirstOrDefault();
        }

        #endregion

    }
}
