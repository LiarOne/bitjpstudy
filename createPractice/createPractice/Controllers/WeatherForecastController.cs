using createPractice.Entity;
using createPractice.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace createPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            this.weatherForecastService = weatherForecastService;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        //[Route("time")]
        //[HttpGet]
        //public string GetTime()
        //{
        //    string time = DateTime.Now.ToString();
        //    return time;
        //}

        //[Route("register")]
        [HttpPost]
        public InfoEntity Register(InfoEntity userInfo)
        {
            var result = this.weatherForecastService.Register(userInfo);
            return result;
        }

        [HttpGet]
        public IEnumerable<InfoEntity> SearchAll()
        {
            var result = this.weatherForecastService.SearchAll();
            return result;
        }

        [Route("search")]
        [HttpGet]
        public InfoEntity SearchById(string userId)
        {
            var result = this.weatherForecastService.SearchById(userId);
            return result;
        }

        [HttpPut]
        public InfoEntity Update(InfoEntity userInfo)
        {
            var result = this.weatherForecastService.Update(userInfo);
            return result;
        }

        [HttpDelete]
        public bool Delete(string? userId)
        {
            var result = this.weatherForecastService.Delete(userId);
            return result;
        }
    }
}