using Microsoft.AspNetCore.Mvc;

namespace Insurance_Claims_Portal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet("name")]
        public string GetName()
        {
            return "Aditya";
        }


    }
}
