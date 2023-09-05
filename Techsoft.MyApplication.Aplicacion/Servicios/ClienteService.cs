using MyApplication.Contexto;
using MyApplication.Contratos;
using MyApplication.Entidades;
using MyApplication.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.MyApplication.Aplicacion.Servicios
{

    public class ClienteService
    {
        private readonly IRepositorio<Cliente> _repo ;

        public ClienteService(IRepositorio<Cliente> repo)
        {
            //_repo = RepositorioFabrik.CrearRepositorio<Cliente>
            //    (RepositorioFabrik.DBOptions.SQLServer);

            _repo = repo;
        }


        public void Guardar(string nombre, string apellido, string telefono, string direccion, int edad)
        {
            var cliente = new Cliente(nombre, apellido, telefono, direccion, edad);

            //Aseguramos que el cliente no se repita
            ClienteNotExists(cliente);

            _repo.Guardar(cliente);
        }

        //Guarda
        private void ClienteNotExists(Cliente cliente)
        {
           if( ConsultarTodos().Where(c=> c.Nombre == cliente.Nombre
            && c.Apellido == cliente.Apellido).Count()>0 )
                throw new InvalidOperationException($"El cliente {cliente.Nombre} {cliente.Apellido} ya existe en la base de datos");
        }


        public List<Cliente> ConsultarTodos()
        {
            return _repo.ConsultarTodos();
        }
    }
}
