using Microsoft.AspNetCore.Mvc;
using ViewEvents.Domain.Models;
using ViewEvents.Services.Interfaces;

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

        [HttpGet]
        public IActionResult GetAllEvent()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("id/{id}")]
        public IActionResult GetIdEvent(int id)
        {
            return Ok(_service.GetId(id));
        }

        [HttpGet("{theme}")]
        public IActionResult GetThemeEvent(String theme)
        {
            return Ok(_service.GetTheme(theme));
        }

        [HttpPost]
        public IActionResult setEvent(Event e)
        {
            return Ok(_service.Insert(e));
        }

        [HttpPut]
        public IActionResult updateEvent(Event e)
        {
            return Ok(_service.Update(e));
        }

        [HttpDelete]
        public IActionResult deleteEvent(Event e)
        {
            return Ok(_service.Delete(e));
        }

    }
}