using Microsoft.AspNetCore.Mvc;
using ViewEvents.Services.Interfaces;
using ViewEvents.Services.Services;

namespace ViewEvents.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        protected readonly IEventService _service;
        public EventController(IEventService service)
        {
            _service = service;
        }

        [HttpGet(Name = "")]
        public IActionResult GetAllEvent()
        {
            return Ok(_service.GetAll());
        }
    }
}