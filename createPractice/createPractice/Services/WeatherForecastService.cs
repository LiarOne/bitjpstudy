using Autofac.Extras.DynamicProxy;
using createPractice.Entity;
using createPractice.Repositories;

namespace createPractice.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository weatherForecastRepository;
        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            this.weatherForecastRepository = weatherForecastRepository;
        }
        public InfoEntity Register(InfoEntity userInfo)
        {
            var result = this.weatherForecastRepository.Register(userInfo);
            return result;
        }

        public IEnumerable<InfoEntity> SearchAll()
        {
            var result = this.weatherForecastRepository.SearchAll();
            return result;
        }

        public InfoEntity SearchById(string userId)
        {
            var result = this.weatherForecastRepository.SearchById(userId);
            return result;
        }

        public InfoEntity Update(InfoEntity userInfo)
        {
            var result = this.weatherForecastRepository.Update(userInfo);
            return result;
        }

        public bool Delete(string? userId)
        {
            var result = this.weatherForecastRepository.Delete(userId);
            return result;
        }
    }
}
