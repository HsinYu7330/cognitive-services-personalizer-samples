using PersonalizerTravelAgencyDemo.Models;
using Microsoft.AspNetCore.Mvc;
using PersonalizerTravelAgencyDemo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalizerTravelAgencyDemo.Controllers
{
    [Route("api/[controller]")]
    public class PersonalizerController : Controller
    {
        private readonly IPersonalizerService _service;

        public PersonalizerController(IPersonalizerService service)
        {
            _service = service;
        }

        // POST api/Personalizer/Recommendation
        [HttpPost("Recommendation")]
        public JsonResult Recommendation([FromBody] UserContext context)
        {
            var currentContext = this.CreatePersonalizerContext(context, context.UseUserAgent ? Request : null);

            return new JsonResult(_service.GetRecommendations(currentContext));
        }

        // POST api/Personalizer/Reward
        [HttpPost("Reward")]
        public void Reward([FromBody] Reward reward)
        {
            _service.Reward(reward);
        }
    }
}