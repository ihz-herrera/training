using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Contratos;
using MyApplication.Entidades;
using Techsoft.MyApplication.Aplicacion.Servicios;

namespace TechSoft.MyApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        //private readonly IRepositorio<Cliente> _repo;

        private readonly ClienteService _service;

        public ClientesController( ClienteService service)
        {
            _service = service;
        }



        [HttpGet]
        public IActionResult ConsultarClientes()
        {
           
            var clientes = _service.ConsultarTodos();
            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult GuardarCliente( Cliente cliente)
        {
            
            _service.Guardar(cliente.Nombre, cliente.Apellido, cliente.Telefono, cliente.Direccion, cliente.Edad);
            return Ok();
        }


    }
}
