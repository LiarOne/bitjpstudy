using Autofac.Extras.DynamicProxy;
using createPractice.AOP;
using createPractice.Entity;

namespace createPractice.Repositories
{
    [Intercept(typeof(LoggingInterceptor))]
    public interface IWeatherForecastRepository
    {
        public InfoEntity Register(InfoEntity userInfo);
        public IEnumerable<InfoEntity> SearchAll();
        public InfoEntity SearchById(string userId);
        public InfoEntity Update(InfoEntity userInfo);
        public bool Delete(string? userId);
    }
}
