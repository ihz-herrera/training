using Microsoft.AspNetCore.Mvc;

namespace TechSoft.MyApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {

        [HttpGet]
        public IActionResult ConsultarDoctores()
        {
            return Ok();
        }
    }
}
