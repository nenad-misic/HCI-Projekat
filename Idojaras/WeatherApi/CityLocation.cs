using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace WeatherAPI
{
    public class CityLocation
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public static CityLocation GetCity()
        {
            string cityJson = LocationApi.GetLocation();
            LocationWrapper wrapper = (LocationWrapper)JsonConvert.DeserializeObject(cityJson, typeof(LocationWrapper));
            string[] latLong = toLatLong(wrapper.loc);
            CityLocation retVal = new CityLocation()
            {
                Name = wrapper.city,
                Latitude = Double.Parse(latLong[0]),
                Longitude = Double.Parse(latLong[1])
            };
            return retVal;
        }

        private static string[] toLatLong(string latLong)
        {
            string[] numbers = latLong.Split(',');
            return numbers;
        }
    }
}
