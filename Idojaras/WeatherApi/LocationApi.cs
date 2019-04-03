using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WeatherAPI
{
    class LocationApi
    {
        private static readonly HttpClient client = new HttpClient();
        public static string GetLocation()
        {
            var retVal = getLocationAsync().GetAwaiter().GetResult();
            if (retVal != null)
            {
                return retVal;
            }
            else
            {
                return "";
            }
        }
        private static async Task<string> getLocationAsync()
        {
            try
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                return await client.GetStringAsync("https://www.ipinfo.io?token=dcea6dee5a66df");
            }
            catch (Exception e)
            {
                return "{}";
            }
        }
    }
}
