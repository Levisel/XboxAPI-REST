using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Data
{
    public class DataCliente: IData<Cliente>
    {
        XboxGamePassEntities _context;
        public DataCliente()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        #region Métodos de Inserción/Actualización/Eliminación

        public void Insertar(Cliente cliente)
        {
            cliente.Cli_LogicalDelete = false;
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Actualizar(Cliente cliente)
        {
            Cliente clienteActual = buscarPorId(cliente.Cli_Cedula);
            //El operador ?? se usa si algún campo del cliente proporcionado es nulo, se conservará el valor existente en el cliente actual
            clienteActual.Cli_Nombre = cliente.Cli_Nombre ?? clienteActual.Cli_Nombre;
            clienteActual.Cli_Apellido = cliente.Cli_Apellido ?? clienteActual.Cli_Apellido;
            clienteActual.Cli_BirthDate = cliente.Cli_BirthDate ?? clienteActual.Cli_BirthDate;
            clienteActual.Cli_Pais = cliente.Cli_Pais ?? clienteActual.Cli_Pais;
            clienteActual.Cli_Email = cliente.Cli_Email ?? clienteActual.Cli_Email;
            _context.SaveChanges();
        }

        public void Eliminar(string cedula)
        {
            Cliente clienteActual = buscarPorId(cedula);
            if(clienteActual != null)
            {
                clienteActual.Cli_LogicalDelete = true;
                _context.SaveChanges();
            }
        }

        #endregion

        #region Métodos de Seleccion/Lectura

        public List<Cliente> Listar()
        {
            return _context.Clientes.Where(cli => cli.Cli_LogicalDelete == false).ToList();
        }


        public Cliente buscarPorId(string id)
        {
            return _context.Clientes.Where(cli => cli.Cli_Cedula == id && cli.Cli_LogicalDelete == false).FirstOrDefault();    
        }

        #endregion

        #region Metodos no implementados (sobrecargados)
        public Cliente buscarPorId(int id)
        {
            return null;
        }
        
        public List<Cliente> Listar(string id)
        {
            return null;
        }

        public void Eliminar(int id)
        {
            return;
        }


        #endregion

    }
}
