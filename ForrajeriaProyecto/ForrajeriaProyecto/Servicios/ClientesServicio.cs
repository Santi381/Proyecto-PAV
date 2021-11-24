using System;
using System.Collections.Generic;
using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.RepositoriosDB;

namespace ForrajeriaProyecto.Servicios
{
    public class ClientesServicio
    {
        private ClientesRepositorio clientesRepositorio;
        public ClientesServicio(ClientesRepositorio clientesRepo)
        {
            clientesRepositorio = clientesRepo;
        }

        public ClientesServicio()
        {
            clientesRepositorio = new ClientesRepositorio();
        }

        public List<Cliente> GetClientes()
        {
            return clientesRepositorio.GetClientes();
        }
        public List<Cliente> GetClientesActivos()
        {
            return clientesRepositorio.GetClientesActivos();
        }
        public List<Cliente> GetClientes(Cliente c, bool mostrarTodos)
        {
            return clientesRepositorio.GetClientes(c, mostrarTodos);
        }

        public bool RegistrarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new ApplicationException("Cliente requerido");
            var filasAfectadas = clientesRepositorio.RegistrarCliente(cliente);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Cliente GetCliente(long id)
        {
            var cliente = clientesRepositorio.GetCliente(id);
            return cliente;
        }
        public void ModificarCliente(Cliente c)
        {
            var filasAfectadas = clientesRepositorio.ModificarCliente(c);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void ValidarCliente(Cliente cliente)
        {
            cliente.ValidarNroDocumento();
            cliente.ValidarNombre();
            cliente.ValidarApellido();
            cliente.ValidarTelefono();
            cliente.ValidarDireccion();
        }

        public void DarBajaCliente(Cliente c)
        {
            var filasAfectadas = clientesRepositorio.DarBajaCliente(c);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al dar de baja al usuario");
        }
    }
}
