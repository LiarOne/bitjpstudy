using createPractice.Entity;
using Npgsql;
using System.Data;
using Dapper;
using System.Data.Common;
using Autofac.Extras.DynamicProxy;

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
            var builder = new SqlBuilder();
            var builderTemplate = builder.AddTemplate("insert into m_user(user_name,user_age) values (@userName, @userAge) returning *");
            using IDbConnection dbConnection = this.Connection;
            dbConnection.Open();
            return dbConnection.Query<InfoEntity>(builderTemplate.RawSql, userInfo).FirstOrDefault();
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
            var builder = new SqlBuilder();
            builder
                .Select("MU.user_id")
                .Select("MU.user_name")
                .Select("MU.user_age")
                .Select("MU.register_time");

            builder.Where("MU.user_id = @userId");
            builder.AddParameters(new { @userId = userId});

            var builderTemplate = builder.AddTemplate("select /**select**/ from m_user MU /**where**/");
            using IDbConnection dbConnection = this.Connection;
            dbConnection.Open();
            return dbConnection.Query<InfoEntity>(builderTemplate.RawSql, builderTemplate.Parameters).FirstOrDefault();
        }

        public InfoEntity Update(InfoEntity userInfo)
        {
            var builder = new SqlBuilder();
            builder
                .Select("user_name = @userName")
                .Select("user_age = @userAge")
                .Where("user_id = @userId");

            var builderTemplate = builder.AddTemplate("update m_user set /**select**/ /**where**/ returning *");
            using IDbConnection dbConnection = this.Connection;
            dbConnection.Open();
            return dbConnection.Query<InfoEntity>(builderTemplate.RawSql, userInfo).FirstOrDefault();
        }

        public bool Delete(string? userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                var builder = new SqlBuilder();
                var builderTemplate = builder.AddTemplate("delete from m_user where user_id = @userId");
                using IDbConnection dbConnection = this.Connection;
                dbConnection.Open();
                dbConnection.Execute(builderTemplate.RawSql, new { @userId = userId });
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
