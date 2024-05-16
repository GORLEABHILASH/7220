using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using YourNamespace.Models;
namespace YourNamespace.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            // Placeholder for weather forecast logic
            return new List<WeatherForecast>
            {
                new WeatherForecast { Date = DateTime.Now, TemperatureC = 25, Summary = "Sunny" },
                new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = 20, Summary = "Cloudy" },
                new WeatherForecast { Date = DateTime.Now.AddDays(2), TemperatureC = 15, Summary = "Rainy" }
            };
        }
    }



}
