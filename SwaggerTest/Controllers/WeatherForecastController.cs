using Microsoft.AspNetCore.Mvc;

namespace SwaggerTest.Controllers
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


        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Err))]
        [HttpGet(Name = "GetWeatherForecast")]
        public int Get()
        {
            return 0;
        }
    }
}