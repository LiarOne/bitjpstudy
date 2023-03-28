using createPractice.Entity;

namespace createPractice.Services
{
    public interface IWeatherForecastService
    {
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public InfoEntity Register(InfoEntity userInfo);

        /// <summary>
        /// 检索全部数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<InfoEntity> SearchAll();

        /// <summary>
        /// 根据user id检索数据
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public InfoEntity SearchById(string userId);

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public InfoEntity Update(InfoEntity userInfo);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Delete(string? userId);
    }
}
