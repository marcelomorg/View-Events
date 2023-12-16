using Microsoft.AspNetCore.Mvc;
using ViewEvents.Domain.Models;
using ViewEvents.Services.Interfaces;

namespace ViewEvents.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpeakerController : ControllerBase
    {
        private readonly ISpeakerService _service;
        public SpeakerController(ISpeakerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllSpeaker()
        {
            return Ok(_service.Getall());
        }

        [HttpGet("id/{id}")]
        public IActionResult GetIdSpeaker(int id)
        {
            return Ok(_service.GetId(id));
        }

        [HttpGet("name/{name}")]
        public IActionResult GetNameSpeaker(string name)
        {
            return Ok(_service.GetName(name));
        }

        [HttpPost]
        public IActionResult SetSpeaker(Speaker speaker)
        {
            return Ok(_service.Insert(speaker));
        }

        [HttpPut]
        public IActionResult UpdateSpeaker(Speaker speaker)
        {
            return Ok(_service.Update(speaker));
        }

        [HttpDelete]
        public IActionResult DeleteSpeaker(Speaker speaker)
        {
            return Ok(_service.Delete(speaker));
        }

    }
}