using Microsoft.AspNetCore.Mvc;
using SerializationDemo.Components.Interfaces;

namespace SerializationDemo.Controllers
{
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        public readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var status = _statusService.GetStatus();
            return Ok(status);
        }
    }
}
