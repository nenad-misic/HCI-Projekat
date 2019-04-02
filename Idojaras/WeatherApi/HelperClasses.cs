using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    class Biggest
    {
        public String cod, message;
        public int cnt;
        public List<ListObject> list;
        public Object city;
    }

    class ListObject
    {
        public int dt;
        public String dt_txt;
        public Mainy main;
        public List<Weathery> weather;
        public Object clouds;
        public Windy wind;
        public Object sys;
    }

    class Mainy
    {
        public double temp, temp_min, temp_max, pressure, sea_level, grnd_level, temp_kf;
        public int humidity;
    }

    class Weathery
    {
        public int id;
        public string main, description, icon;
    }

    class Windy
    {
        public double speed, deg;
    }
}
