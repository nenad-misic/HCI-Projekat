using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WeatherAPI
{
    class WeatherApi
    {
        private static readonly HttpClient client = new HttpClient();

        public static string getWeather(int id)
        {
            var retVal = getWeatherAsync(id).GetAwaiter().GetResult();
            if (retVal != null)
            {
                return retVal.ToString();
            }
            else
            {
                return "";
            }
        }

        private static async Task<string> getWeatherAsync(int id)
        {
            try {
                return await client.GetStringAsync("http://api.openweathermap.org/data/2.5/forecast?id=" + id.ToString() + "&appid=546808a4356c606f832e12c5588bb3df");
            }catch(Exception e)
            {
                return "{}";
            }
        }
    }
}
