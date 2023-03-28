using createPractice.Entity;
using Npgsql;
using System.Data;
using Dapper;

namespace createPractice.Repositories
{
    public class WeatherForecastRepository: IWeatherForecastRepository
    {
        public readonly string connectionString;
        public WeatherForecastRepository()
        {
            this.connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123456;Database=postgres";
        }
        public IDbConnection Connection
        {
            get { return new NpgsqlConnection(this.connectionString);}
        }

        public InfoEntity Register(InfoEntity userInfo)
        {
            userInfo.userId = Guid.NewGuid().ToString("N");
            userInfo.registerTime = DateTime.Now;
            return userInfo;
        }
        
        public IEnumerable<InfoEntity> SearchAll()
        {
            var builder = new SqlBuilder();
            builder
                .Select("MU.user_id")
                .Select("MU.user_name")
                .Select("MU.user_age")
                .Select("MU.register_time");

            var builderTemplate = builder.AddTemplate("select /**select**/ from m_user MU");
            using IDbConnection dbConnection = this.Connection;
            dbConnection.Open();
            return dbConnection.Query<InfoEntity>(builderTemplate.RawSql, builderTemplate.Parameters);
        }

        public InfoEntity SearchById(string userId)
        {
            InfoEntity searchInfo = new InfoEntity();
            searchInfo.userId = userId;
            searchInfo.userName = "userNameById";
            searchInfo.userAge = 789;
            searchInfo.registerTime = DateTime.Now;

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
