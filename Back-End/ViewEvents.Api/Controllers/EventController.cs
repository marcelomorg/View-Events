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
        public async Task<IActionResult> GetAllEvent()
        {
            return Ok( await _service.GetAll());
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetIdEvent(int id)
        {
            return Ok(await _service.GetId(id));
          
        }

        [HttpGet("{theme}")]
        public async Task<IActionResult> GetThemeEvent(String theme)
        {
            return Ok(await _service.GetTheme(theme));
        }

        [HttpPost]
        public async Task<IActionResult> setEvent(Event e)
        {
            return Ok(_service.Insert(e));
        }

        [HttpPut]
        public async Task<IActionResult> updateEvent(Event e)
        {
            return Ok(_service.Update(e));
        }

        [HttpDelete]
        public async Task<IActionResult> deleteEvent(Event e)
        {
            return Ok(_service.Delete(e));
        }

    }
}