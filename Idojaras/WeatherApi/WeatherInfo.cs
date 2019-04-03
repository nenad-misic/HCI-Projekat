using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras.WeatherApi
{
    public class WeatherInfo : INotifyPropertyChanged
    {
        public WeatherInfo()
        {
            this.MinTemp = "";
            this.MaxTemp = "";
            this.Temp = "";
            this.Humidity = "";
            this.Pressure = "";
            this.Status = "";
            this.Image = "";
            this.Time = "";
            this.Date = "";

        }
            public WeatherInfo(WeatherAPI.WeatherMeasurement wm)
        {
            this.MinTemp = wm.MinTemp.ToString() + "°/";
            this.MaxTemp = wm.MaxTemp.ToString() + "°";
            this.Temp = Convert.ToInt32(wm.Temp - 273).ToString() + "°";
            this.Humidity = wm.Humidity.ToString() + "%";
            this.Pressure = wm.Pressure.ToString() + "mbar";
            this.Status = wm.Status;
            this.Image = "Images/" + wm.Status + ".png";
            this.Time = wm.Time.ToString("HH:mm");
            this.Date = wm.Time.DayOfWeek +", " + wm.Time.ToShortDateString();
        }
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string _temp;
        public string _maxtemp;
        public string _mintemp;
        public string _humidity;
        public string _pressure;
        public string _status;
        public string _description;
        public string _time;
        public string _date;
        public string _image;

        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                if (value != _image)
                {
                    _image = value;
                    OnPropertyChanged("Image");
                }
            }
        }

        public string Temp
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
        public string MaxTemp
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
        public string MinTemp
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
        public string Humidity
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
        public string Pressure
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
        public string Time
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

        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (value != _date)
                {
                    _date = value;
                    OnPropertyChanged("Date");
                }
            }
        }
        


    }
}
