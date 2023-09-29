using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Contratos;
using MyApplication.Entidades;
using Techsoft.MyApplication.Aplicacion.Servicios;

namespace TechSoft.MyApplication.Api.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        //private readonly IRepositorio<Cliente> _repo;

        private readonly ClienteService _service;

        public ClientesController(ClienteService service)
        {
            _service = service;
        }



        [HttpGet("v1")]
        public IActionResult ConsultarClientes()
        {
            try
            {
                var clientes = _service.ConsultarTodos();
                return Ok(clientes);
            }catch(System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            
        }

        [HttpGet()]
        [ProducesErrorResponseType(typeof(ErrorResult))]
        public async Task<ActionResult<List<Cliente>>> ConsultarClientesTyped()
        {
            try
            {
                var clientes = await _service.ConsultarTodos();
                return Ok(clientes);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, 
                    new ErrorResult (2058,ex.Message,ex.StackTrace));
            }
        }

        [HttpPost]
        public IActionResult GuardarCliente(Cliente cliente)
        {

            _service.Guardar(cliente.Nombre, cliente.Apellido, cliente.Telefono, cliente.Direccion, cliente.Edad);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ConsultarClientePorId(Guid id)
        {
            var cliente = await _service.ConsultarPorId(id);

            Thread.Sleep(5000);

            return Ok(cliente);
        }
    }



    record ErrorResult
    (int Error ,string Mensaje, string Detalle);


}
