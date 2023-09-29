using Microsoft.AspNetCore.Mvc;
using MyApplication.Entidades;
using Techsoft.MyApplication.Aplicacion.Servicios;

namespace TechSoft.MyApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {

        private readonly DoctorService _service;

        public DoctoresController(DoctorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Doctor>>> ConsultarDoctores()
        {
            var doctores = await _service.ConsultarTodos();

            return Ok(doctores);
        }

        [HttpPost]
        public async Task<ActionResult> GuardarDoctor(Doctor doctor)
        {
            _service.Guardar(doctor.Nombre, doctor.Apellido, doctor.Telefono,doctor.Cedula, doctor.Edad);
            return Ok();
        }
    }
}
