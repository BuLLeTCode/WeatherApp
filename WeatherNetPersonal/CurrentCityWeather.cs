using System;
using System.Globalization;

namespace WeatherNetPersonal
{
    class CurrentCityWeather
    {
        public string City { get;}

        public CurrentCityWeather(string city)
        {
            City = city;
        }

        public bool IsCityValide()
        {
            if (WeatherNet.Clients.CurrentWeather.GetByCityName(City, "Latvia", "English", "metric").Success)
            {
                return true;
            }

            return false;
        }

        public string GetTemp()
        {
            return
                Convert.ToString(
                    WeatherNet.Clients.CurrentWeather.GetByCityName(City, "Latvia", "English", "metric").Item.Temp,
                    CultureInfo.InvariantCulture);
        }

        public string GetWeatherIcone()
        {
            return WeatherNet.Clients.CurrentWeather.GetByCityName(City, "Latvia", "English", "metric").Item.Icon;
        }

        public string GetWind()
        {
            return Convert.ToString(WeatherNet.Clients.CurrentWeather.GetByCityName(City, "Latvia", "English", "metric").Item.WindSpeed, 
                CultureInfo.InvariantCulture);
        }

        public string GetHumidity()
        {
            return Convert.ToString(WeatherNet.Clients.CurrentWeather.GetByCityName(City, "Latvia", "English", "metric").Item.Humidity + " %",
                CultureInfo.InvariantCulture);
        }
    }
}
