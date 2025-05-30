using ApostasEsportivasApi.Models;
using ApostasEsportivasApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApostasEsportivasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly BettingService _service = new();

        [HttpGet]
        public IActionResult GetEvents()
        {
            return Ok(_service.GetAllEvents());
        }

        [HttpPost("bet")]
        public IActionResult SimulateMultipleBets([FromBody] List<BetRequest> requests)
        {
            try
            {
                var results = requests.Select(r => _service.SimulateBet(r)).ToList();
                return Ok(results);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
