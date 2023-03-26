using createPractice.Entity;

namespace createPractice.Repositories
{
    public interface IWeatherForecastRepository
    {
        public InfoEntity Register(InfoEntity userInfo);
        public List<InfoEntity> SearchAll();
        public InfoEntity SearchById(string userId);
        public InfoEntity Update(InfoEntity userInfo);
        public bool Delete(string? userId);
    }
}
