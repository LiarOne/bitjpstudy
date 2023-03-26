module.exports = (function () {
    const URL_BASE = 'http://localhost:3000'
    const API_BASE = '/api'

    return {
        URL_BASE,
        API_BASE,
        API: {
            TIME: API_BASE + '/WeatherForecast/time'
        }
    }
})()