using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [ApiController]
    // [Route("[controller]")] // Round chung cho tất cả các phương thức nằm trong 1 APIController
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get-weather")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet]
        [Route("get-random-number")]
        public int RandomNumber()
        {
            return new Random().Next(1000000);
        }
        // Viết thêm 1 API tính chỉ số BMI có 2 tham số là Chiều cao (m) vầ cân nặng (kg)
        [HttpGet("get-bmi")]
        public string CalculateBMI(double height, double weight)
        {
            double bmi = Math.Round(weight / (height * height), 2);
            if (bmi < 18.5)
            {
                return $"Với BMI {bmi} thì bạn đang trong trạng thái gầy";
            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                return $"Với BMI {bmi} thì bạn đang khá cân đối";
            }
            else return $"Với BMI {bmi} thì bạn là đối thủ nặng kí";
        }
    }
}