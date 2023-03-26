using createPractice.Entity;

namespace createPractice.Repositories
{
    public class WeatherForecastRepository: IWeatherForecastRepository
    {
        public InfoEntity Register(InfoEntity userInfo)
        {
            userInfo.userId = Guid.NewGuid().ToString("N");
            userInfo.registerTime = DateTime.Now.ToString();
            return userInfo;
        }

        public List<InfoEntity> SearchAll()
        {
            InfoEntity registerInfo = new InfoEntity();
            registerInfo.userId = Guid.NewGuid().ToString("N");
            registerInfo.userName = "searchAll111";
            registerInfo.userAge = "123";
            registerInfo.registerTime = DateTime.Now.ToString();

            InfoEntity registerInfo2 = new InfoEntity();
            registerInfo2.userId = Guid.NewGuid().ToString("N");
            registerInfo2.userName = "searchAll222";
            registerInfo2.userAge = "456";
            registerInfo2.registerTime = DateTime.Now.ToString();

            List<InfoEntity> searchInfo = new List<InfoEntity>();

            searchInfo.Add(registerInfo);
            searchInfo.Add(registerInfo2);

            return searchInfo;
        }

        public InfoEntity SearchById(string userId)
        {
            InfoEntity searchInfo = new InfoEntity();
            searchInfo.userId = userId;
            searchInfo.userName = "userNameById";
            searchInfo.userAge = "789";
            searchInfo.registerTime = DateTime.Now.ToString();

            return searchInfo;
        }

        public InfoEntity Update(InfoEntity userInfo)
        {
            InfoEntity registerInfo = userInfo;
            return registerInfo;
        }

        public bool Delete(string? userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
