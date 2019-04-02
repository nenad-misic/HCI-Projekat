using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace WeatherAPI
{
    public class WeatherMeasurement : INotifyPropertyChanged
    {

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public double _temp;
        public double _maxtemp;
        public double _mintemp;
        public double _humidity;
        public double _pressure;
        public string _status;
        public string _description;
        public DateTime _time;

        
        public double Temp
        {
            get
            {
                return _temp;
            }
            set
            {
                if (value != _temp)
                {
                    _temp = value;
                    OnPropertyChanged("Temp");
                }
            }
        }
        public double MaxTemp
        {
            get
            {
                return _maxtemp;
            }
            set
            {
                if (value != _maxtemp)
                {
                    _maxtemp = value;
                    OnPropertyChanged("MaxTemp");
                }
            }
        }
        public double MinTemp
        {
            get
            {
                return _mintemp;
            }
            set
            {
                if (value != _mintemp)
                {
                    _mintemp = value;
                    OnPropertyChanged("MinTemp");
                }
            }
        }
        public double Humidity
        {
            get
            {
                return _humidity;
            }
            set
            {
                if (value != _humidity)
                {
                    _humidity = value;
                    OnPropertyChanged("Humidity");
                }
            }
        }
        public double Pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                if (value != _pressure)
                {
                    _pressure = value;
                    OnPropertyChanged("Pressure");
                }
            }
        }
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (value != _status)
                {
                    _status = value;
                    OnPropertyChanged("Status");
                }
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        public DateTime Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value != _time)
                {
                    _time = value;
                    OnPropertyChanged("Time");
                }
            }
        }
        public static List<WeatherMeasurement> GetWeatherMeasurements(int id)
        {
            try
            {
                String weatherReadings = WeatherApi.getWeather(id);
                List<WeatherMeasurement> retVal = new List<WeatherMeasurement>();

                Biggest big = (Biggest)JsonConvert.DeserializeObject(weatherReadings, typeof(Biggest));
                foreach (ListObject measurement in big.list)
                {
                    WeatherMeasurement wm = new WeatherMeasurement()
                    {
                        Temp = measurement.main.temp,
                        MaxTemp = measurement.main.temp_max,
                        MinTemp = measurement.main.temp_min,
                        Humidity = measurement.main.humidity,
                        Pressure = measurement.main.pressure,
                        Status = measurement.weather[0].main,
                        Description = measurement.weather[0].description,
                        Time = toDateTime(measurement.dt_txt)
                        //Nomes pls zavrsi ovo ako me ne bude

                    };
                    retVal.Add(wm);
                }
                return retVal;
            }
            catch
            {
                return new List<WeatherMeasurement>();
            }
        }

        private static DateTime toDateTime(string dt_txt)
        {
            string[] numbers = Regex.Split(dt_txt, @"\D+");
            Console.WriteLine("");
            return new DateTime(int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]), int.Parse(numbers[3]), int.Parse(numbers[4]), int.Parse(numbers[5]));
        }
    }
}
