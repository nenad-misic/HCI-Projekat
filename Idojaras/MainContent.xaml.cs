using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

using WeatherAPI;
using System.Collections.ObjectModel;
using Idojaras.WeatherApi;
using System.IO;
using Newtonsoft.Json;
using Idojaras.Models;

namespace Idojaras
{
    /// <summary>
    /// Interaction logic for MainContent.xaml
    /// </summary>
    public partial class MainContent : UserControl, INotifyPropertyChanged
    {
        #region CardClickCallbacks
        public onCardClicked clickedCard0 { get; set; }
        public onCardClicked clickedCard1 { get; set; }
        public onCardClicked clickedCard2 { get; set; }
        public onCardClicked clickedCard3 { get; set; }
        public onCardClicked clickedCard4 { get; set; }
        #endregion
        #region CardClickHandlers
        public int onClicked0()
        {
            this.selectedCard = 0;
            return 0;
        }
        public int onClicked1()
        {
            this.selectedCard = 1;
            return 1;
        }
        public int onClicked2()
        {
            this.selectedCard = 2;
            return 2;
        }
        public int onClicked3()
        {
            this.selectedCard = 3;
            return 3;
        }
        public int onClicked4()
        {
            this.selectedCard = 4;
            return 4;
        }
        #endregion
        #region ColSpan
        public int _colspan0;
        public int ColSpan0
        {
            get
            {
                return _colspan0;
            }
            set
            {
                if (value != _colspan0)
                {
                    _colspan0 = value;
                    OnPropertyChanged("ColSpan0");
                }
            }
        }
        public int _colspan1;
        public int ColSpan1
        {
            get
            {
                return _colspan1;
            }
            set
            {
                if (value != _colspan1)
                {
                    _colspan1 = value;
                    OnPropertyChanged("ColSpan1");
                }
            }
        }
        public int _colspan2;
        public int ColSpan2
        {
            get
            {
                return _colspan2;
            }
            set
            {
                if (value != _colspan2)
                {
                    _colspan2 = value;
                    OnPropertyChanged("ColSpan2");
                }
            }
        }
        public int _colspan3;
        public int ColSpan3
        {
            get
            {
                return _colspan3;
            }
            set
            {
                if (value != _colspan3)
                {
                    _colspan3 = value;
                    OnPropertyChanged("ColSpan3");
                }
            }
        }
        public int _colspan4;
        public int ColSpan4
        {
            get
            {
                return _colspan4;
            }
            set
            {
                if (value != _colspan4)
                {
                    _colspan4 = value;
                    OnPropertyChanged("ColSpan4");
                }
            }
        }
        #endregion
        #region Col
        public int _col0;
        public int _col1;
        public int _col2;
        public int _col3;
        public int _col4;
        public int Col0
        {
            get
            {
                return _col0;
            }
            set
            {
                if (value != _col0)
                {
                    _col0 = value;
                    OnPropertyChanged("Col0");
                }
            }
        }
        public int Col1
        {
            get
            {
                return _col1;
            }
            set
            {
                if (value != _col1)
                {
                    _col1 = value;
                    OnPropertyChanged("Col1");
                }
            }
        }
        public int Col2
        {
            get
            {
                return _col2;
            }
            set
            {
                if (value != _col2)
                {
                    _col2 = value;
                    OnPropertyChanged("Col2");
                }
            }
        }
        public int Col3
        {
            get
            {
                return _col3;
            }
            set
            {
                if (value != _col3)
                {
                    _col3 = value;
                    OnPropertyChanged("Col3");
                }
            }
        }
        public int Col4
        {
            get
            {
                return _col4;
            }
            set
            {
                if (value != _col4)
                {
                    _col4 = value;
                    OnPropertyChanged("Col4");
                }
            }
        }

        #endregion
        #region RowSpan
        public int _rowspan0;
        public int _rowspan1;
        public int _rowspan2;
        public int _rowspan3;
        public int _rowspan4;
        public int RowSpan0
        {
            get
            {
                return _rowspan0;
            }
            set
            {
                if (value != _rowspan0)
                {
                    _rowspan0 = value;
                    OnPropertyChanged("RowSpan0");
                }
            }
        }
        public int RowSpan1
        {
            get
            {
                return _rowspan1;
            }
            set
            {
                if (value != _rowspan1)
                {
                    _rowspan1 = value;
                    OnPropertyChanged("RowSpan1");
                }
            }
        }
        public int RowSpan2
        {
            get
            {
                return _rowspan2;
            }
            set
            {
                if (value != _rowspan2)
                {
                    _rowspan2 = value;
                    OnPropertyChanged("RowSpan2");
                }
            }
        }
        public int RowSpan3
        {
            get
            {
                return _rowspan3;
            }
            set
            {
                if (value != _rowspan3)
                {
                    _rowspan3 = value;
                    OnPropertyChanged("RowSpan3");
                }
            }
        }
        public int RowSpan4
        {
            get
            {
                return _rowspan4;
            }
            set
            {
                if (value != _rowspan4)
                {
                    _rowspan4 = value;
                    OnPropertyChanged("RowSpan4");
                }
            }
        }
        #endregion
        #region Visibilities
        public Visibility _vN0;
        public Visibility _vN1;
        public Visibility _vN2;
        public Visibility _vN3;
        public Visibility _vN4;
        public Visibility _vY0;
        public Visibility _vY1;
        public Visibility _vY2;
        public Visibility _vY3;
        public Visibility _vY4;
        public Visibility visibilityN0
        {
            get
            {
                return _vN0;
            }
            set
            {
                if (value != _vN0)
                {
                    _vN0 = value;
                    OnPropertyChanged("visibilityN0");
                }
            }
        }
        public Visibility visibilityN1
        {
            get
            {
                return _vN1;
            }
            set
            {
                if (value != _vN1)
                {
                    _vN1 = value;
                    OnPropertyChanged("visibilityN1");
                }
            }
        }
        public Visibility visibilityN2
        {
            get
            {
                return _vN2;
            }
            set
            {
                if (value != _vN2)
                {
                    _vN2 = value;
                    OnPropertyChanged("visibilityN2");
                }
            }
        }
        public Visibility visibilityN3
        {
            get
            {
                return _vN3;
            }
            set
            {
                if (value != _vN3)
                {
                    _vN3 = value;
                    OnPropertyChanged("visibilityN3");
                }
            }
        }
        public Visibility visibilityN4
        {
            get
            {
                return _vN4;
            }
            set
            {
                if (value != _vN4)
                {
                    _vN4 = value;
                    OnPropertyChanged("visibilityN4");
                }
            }
        }
        public Visibility visibilityY0
        {
            get
            {
                return _vY0;
            }
            set
            {
                if (value != _vY0)
                {
                    _vY0 = value;
                    OnPropertyChanged("visibilityY0");
                }
            }
        }
        public Visibility visibilityY1
        {
            get
            {
                return _vY1;
            }
            set
            {
                if (value != _vY1)
                {
                    _vY1 = value;
                    OnPropertyChanged("visibilityY1");
                }
            }
        }
        public Visibility visibilityY2
        {
            get
            {
                return _vY2;
            }
            set
            {
                if (value != _vY2)
                {
                    _vY2 = value;
                    OnPropertyChanged("visibilityY2");
                }
            }
        }
        public Visibility visibilityY3
        {
            get
            {
                return _vY3;
            }
            set
            {
                if (value != _vY3)
                {
                    _vY3 = value;
                    OnPropertyChanged("visibilityY3");
                }
            }
        }
        public Visibility visibilityY4
        {
            get
            {
                return _vY4;
            }
            set
            {
                if (value != _vY4)
                {
                    _vY4 = value;
                    OnPropertyChanged("visibilityY4");
                }
            }
        }
        #endregion
        #region selectedCarPropSetting

        private int _selectedCard;
        public int selectedCard
        {
            get { return _selectedCard; }
            set
            {
                _selectedCard = value;
                switch (_selectedCard) {
                    case 0:
                        this.ColSpan0 = 3;
                        this.ColSpan1 = 2;
                        this.ColSpan2 = 2;
                        this.ColSpan3 = 2;
                        this.ColSpan4 = 2;
                        this.Col0 = 0;
                        this.Col1 = 3;
                        this.Col2 = 5;
                        this.Col3 = 7;
                        this.Col4 = 9;
                        this.RowSpan0 = 2;
                        this.RowSpan1 = 1;
                        this.RowSpan2 = 1;
                        this.RowSpan3 = 1;
                        this.RowSpan4 = 1;
                        this.visibilityN0 = Visibility.Hidden;
                        this.visibilityN1 = Visibility.Visible;
                        this.visibilityN2 = Visibility.Visible;
                        this.visibilityN3 = Visibility.Visible;
                        this.visibilityN4 = Visibility.Visible;
                        this.visibilityY0 = Visibility.Visible;
                        this.visibilityY1 = Visibility.Hidden;
                        this.visibilityY2 = Visibility.Hidden;
                        this.visibilityY3 = Visibility.Hidden;
                        this.visibilityY4 = Visibility.Hidden;
                        this.DayDetail = this.Day0Detail;
                        break;
                    case 1:
                        this.ColSpan0 = 2;
                        this.ColSpan1 = 3;
                        this.ColSpan2 = 2;
                        this.ColSpan3 = 2;
                        this.ColSpan4 = 2;
                        this.Col0 = 0;
                        this.Col1 = 2;
                        this.Col2 = 5;
                        this.Col3 = 7;
                        this.Col4 = 9;
                        this.RowSpan0 = 1;
                        this.RowSpan1 = 2;
                        this.RowSpan2 = 1;
                        this.RowSpan3 = 1;
                        this.RowSpan4 = 1;
                        this.visibilityN0 = Visibility.Visible;
                        this.visibilityN1 = Visibility.Hidden;
                        this.visibilityN2 = Visibility.Visible;
                        this.visibilityN3 = Visibility.Visible;
                        this.visibilityN4 = Visibility.Visible;
                        this.visibilityY0 = Visibility.Hidden;
                        this.visibilityY1 = Visibility.Visible;
                        this.visibilityY2 = Visibility.Hidden;
                        this.visibilityY3 = Visibility.Hidden;
                        this.visibilityY4 = Visibility.Hidden;
                        this.DayDetail = this.Day1Detail;
                        break;
                    case 2:
                        this.ColSpan0 = 2;
                        this.ColSpan1 = 2;
                        this.ColSpan2 = 3;
                        this.ColSpan3 = 2;
                        this.ColSpan4 = 2;
                        this.Col0 = 0;
                        this.Col1 = 2;
                        this.Col2 = 4;
                        this.Col3 = 7;
                        this.Col4 = 9;
                        this.RowSpan0 = 1;
                        this.RowSpan1 = 1;
                        this.RowSpan2 = 2;
                        this.RowSpan3 = 1;
                        this.RowSpan4 = 1;
                        this.visibilityN0 = Visibility.Visible;
                        this.visibilityN1 = Visibility.Visible;
                        this.visibilityN2 = Visibility.Hidden;
                        this.visibilityN3 = Visibility.Visible;
                        this.visibilityN4 = Visibility.Visible;
                        this.visibilityY0 = Visibility.Hidden;
                        this.visibilityY1 = Visibility.Hidden;
                        this.visibilityY2 = Visibility.Visible;
                        this.visibilityY3 = Visibility.Hidden;
                        this.visibilityY4 = Visibility.Hidden;
                        this.DayDetail = this.Day2Detail;
                        break;
                    case 3:
                        this.ColSpan0 = 2;
                        this.ColSpan1 = 2;
                        this.ColSpan2 = 2;
                        this.ColSpan3 = 3;
                        this.ColSpan4 = 2;
                        this.Col0 = 0;
                        this.Col1 = 2;
                        this.Col2 = 4;
                        this.Col3 = 6;
                        this.Col4 = 9;
                        this.RowSpan0 = 1;
                        this.RowSpan1 = 1;
                        this.RowSpan2 = 1;
                        this.RowSpan3 = 2;
                        this.RowSpan4 = 1;
                        this.visibilityN0 = Visibility.Visible;
                        this.visibilityN1 = Visibility.Visible;
                        this.visibilityN2 = Visibility.Visible;
                        this.visibilityN3 = Visibility.Hidden;
                        this.visibilityN4 = Visibility.Visible;
                        this.visibilityY0 = Visibility.Hidden;
                        this.visibilityY1 = Visibility.Hidden;
                        this.visibilityY2 = Visibility.Hidden;
                        this.visibilityY3 = Visibility.Visible;
                        this.visibilityY4 = Visibility.Hidden;
                        this.DayDetail = this.Day3Detail;
                        break;
                    case 4:
                        this.ColSpan0 = 2;
                        this.ColSpan1 = 2;
                        this.ColSpan2 = 2;
                        this.ColSpan3 = 2;
                        this.ColSpan4 = 3;
                        this.Col0 = 0;
                        this.Col1 = 2;
                        this.Col2 = 4;
                        this.Col3 = 6;
                        this.Col4 = 8;
                        this.RowSpan0 = 1;
                        this.RowSpan1 = 1;
                        this.RowSpan2 = 1;
                        this.RowSpan3 = 1;
                        this.RowSpan4 = 2;
                        this.visibilityN0 = Visibility.Visible;
                        this.visibilityN1 = Visibility.Visible;
                        this.visibilityN2 = Visibility.Visible;
                        this.visibilityN3 = Visibility.Visible;
                        this.visibilityN4 = Visibility.Hidden;
                        this.visibilityY0 = Visibility.Hidden;
                        this.visibilityY1 = Visibility.Hidden;
                        this.visibilityY2 = Visibility.Hidden;
                        this.visibilityY3 = Visibility.Hidden;
                        this.visibilityY4 = Visibility.Visible;
                        this.DayDetail = this.Day4Detail;
                        break;
                    default:
                        break;
                }
            }
        }


        #endregion
        #region PublisherSubscriber
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region SearchControls
        public string _currentCityName;
        public string CurrentCityName {
            get
            {
                return _currentCityName;
            }
            set
            {
                if (value != _currentCityName)
                {
                    _currentCityName = value;
                    OnPropertyChanged("CurrentCityName");
                }
            }
        }

        public string _currentTemperature;
        public string CurrentTemperature
        {
            get
            {
                return _currentTemperature;
            }
            set
            {
                if (value != _currentTemperature)
                {
                    _currentTemperature = value;
                    OnPropertyChanged("CurrentTemperature");
                }
            }
        }

        public int _currentCityId;
        public int CurrentCityId
        {
            get
            {
                return _currentCityId;
            }
            set
            {
                if (value != _currentCityId)
                {
                    _currentCityId = value;
                    OnPropertyChanged("CurrentCityId");
                }
            }
        }

        public void setCurrentCity(City city)
        {
            CurrentCityName = city.Name;
            CurrentCityId = city.Id;
        }

        public void setCurrentTemperature()
        {
            this.CurrentTemperature = Convert.ToInt32((this.WeatherList.ElementAt(0).Temp - 273)).ToString() + "°";
        }

        public List<City> Cities { get; set; }

        public delegate void onSearchClicked(City city);
        public onSearchClicked searchCallback { get; set; }

        void search(City city)
        {
            Thread t = new Thread(() => QueryWeatherApi(city.Id));
            t.Start();
            t.Join();

            fillContentFromList();
            setCurrentCity(city);
            setCurrentTemperature();
            updateIsFavourite();


            this.selectedCard = 0;
        }

        #endregion

        #region Favourites

        public ObservableCollection<City> Favourites { get; set; }
        public bool _isFavourite;
        public bool IsFavourite
        {
            get
            {
                return _isFavourite;
            }
            set
            {
                if (value != _isFavourite)
                {
                    _isFavourite = value;
                    OnPropertyChanged("IsFavourite");
                }
            }
        }
        public void updateFavourite()
        {
            var value = IsFavourite;
            if (value)
            {
                bool exists = false;
                for (int i = 0; i < Favourites.Count; i++)
                {
                    if (CurrentCityId == Favourites.ElementAt(i).Id)
                    {
                        exists = true;
                    }
                }
                if (!exists)
                {
                    Favourites.Add(new City(CurrentCityName, CurrentCityId));
                }
            }
            else
            {
                for (int i = 0; i < Favourites.Count; i++)
                {
                    if (CurrentCityId == Favourites.ElementAt(i).Id)
                    {
                        Favourites.Remove(Favourites.ElementAt(i));
                        break;
                    }
                }
            }
        }

        public void updateIsFavourite()
        {
            for (int i = 0; i < Favourites.Count; i++)
            {
                if (CurrentCityId == Favourites.ElementAt(i).Id)
                {
                    IsFavourite = true;
                    return;
                }
            }
            IsFavourite = false;
            return;
        }

        #endregion

        //public List<WeatherMeasurement> WeatherList;
        public ObservableCollection<WeatherMeasurement> WeatherList;
        public MainContent()
        {
            InitializeComponent();

            clickedCard0 = new onCardClicked(onClicked0);
            clickedCard1 = new onCardClicked(onClicked1);
            clickedCard2 = new onCardClicked(onClicked2);
            clickedCard3 = new onCardClicked(onClicked3);
            clickedCard4 = new onCardClicked(onClicked4);
            this.searchCallback = new onSearchClicked(search);
            Favourites = new ObservableCollection<City>();
            LayoutRoot.DataContext = this;

            // read json file with cities
            using (StreamReader file = File.OpenText("../../Cities/cities.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                this.Cities = (List<City>)serializer.Deserialize(file, typeof(List<City>));
            }

            City belgrade = new City("Belgrade", 792680);

            this.search(belgrade);

            this.DayDetail = this.Day0Detail;
        }

        public void QueryWeatherApi(int id)
        {
            this.WeatherList = new ObservableCollection<WeatherMeasurement>(WeatherMeasurement.GetWeatherMeasurements(id));
            return;
        }

        public WeatherInfo _day0;
        public WeatherInfo Day0 {
            get
            {
                return _day0;
            }
            set
            {
                if (value != _day0)
                {
                    _day0 = value;
                    OnPropertyChanged("Day0");
                }
            }
        }

        public WeatherInfo _day1;
        public WeatherInfo Day1
        {
            get
            {
                return _day1;
            }
            set
            {
                if (value != _day1)
                {
                    _day1 = value;
                    OnPropertyChanged("Day1");
                }
            }
        }

        public WeatherInfo _day2;
        public WeatherInfo Day2
        {
            get
            {
                return _day2;
            }
            set
            {
                if (value != _day2)
                {
                    _day2 = value;
                    OnPropertyChanged("Day2");
                }
            }
        }

        public WeatherInfo _day3;
        public WeatherInfo Day3
        {
            get
            {
                return _day3;
            }
            set
            {
                if (value != _day3)
                {
                    _day3 = value;
                    OnPropertyChanged("Day3");
                }
            }
        }

        public WeatherInfo _day4;
        public WeatherInfo Day4
        {
            get
            {
                return _day4;
            }
            set
            {
                if (value != _day4)
                {
                    _day4 = value;
                    OnPropertyChanged("Day4");
                }
            }
        }

        public ObservableCollection<WeatherInfo> Day0Detail { get; set; }
        public ObservableCollection<WeatherInfo> Day1Detail { get; set; }
        public ObservableCollection<WeatherInfo> Day2Detail { get; set; }
        public ObservableCollection<WeatherInfo> Day3Detail { get; set; }
        public ObservableCollection<WeatherInfo> Day4Detail { get; set; }

        public ObservableCollection<WeatherInfo> _dayDetail;
        public ObservableCollection<WeatherInfo> DayDetail
        {
            get
            {
                return _dayDetail;
            }
            set
            {
                if (value != _dayDetail)
                {
                    _dayDetail = value;
                    OnPropertyChanged("DayDetail");
                }
            }
        }

        public void fillContentFromList()
        {
            var list0 = this.WeatherList.ToList().GetRange(0, 8);
            var list1 = this.WeatherList.ToList().GetRange(8, 8);
            var list2 = this.WeatherList.ToList().GetRange(16, 8);
            var list3 = this.WeatherList.ToList().GetRange(24, 8);
            var list4 = this.WeatherList.ToList().GetRange(32, 8);
            this.Day0 = extractDayFromList(list0);
            this.Day1 = extractDayFromList(list1);
            this.Day2 = extractDayFromList(list2);
            this.Day3 = extractDayFromList(list3);
            this.Day4 = extractDayFromList(list4);
            

            var obslist0 = new ObservableCollection<WeatherInfo>();
            var obslist1 = new ObservableCollection<WeatherInfo>();
            var obslist2 = new ObservableCollection<WeatherInfo>();
            var obslist3 = new ObservableCollection<WeatherInfo>();
            var obslist4 = new ObservableCollection<WeatherInfo>();
            foreach (var li in list0)
                obslist0.Add(new WeatherInfo(li));
            foreach (var li in list1)
                obslist1.Add(new WeatherInfo(li));
            foreach (var li in list2)
                obslist2.Add(new WeatherInfo(li));
            foreach (var li in list3)
                obslist3.Add(new WeatherInfo(li));
            foreach (var li in list4)
                obslist4.Add(new WeatherInfo(li));

            this.Day0Detail = obslist0;
            this.Day1Detail = obslist1;
            this.Day2Detail = obslist2;
            this.Day3Detail = obslist3;
            this.Day4Detail = obslist4;
        }

        private WeatherInfo extractDayFromList(List<WeatherMeasurement> list)
        {
            int min = 999;
            foreach (var hour in list)
            {
                if (hour.MinTemp < min)
                {
                    min = Convert.ToInt32(hour.MinTemp);
                }
            }
            int minTemp = (min - 273);

            int max = 0;
            foreach (var hour in list)
            {
                if (hour.MaxTemp > max)
                {
                    max = Convert.ToInt32(hour.MaxTemp);
                }
            }
            int maxTemp = (max - 273);

            WeatherMeasurement wm = new WeatherMeasurement();
            wm.MinTemp = minTemp;
            wm.MaxTemp = maxTemp;
            wm.Temp = (minTemp+maxTemp)/2;
            wm.Pressure = list[4].Pressure;
            wm.Humidity = list[4].Humidity;
            wm.Status = list[4].Status;
            wm.Description = list[4].Description;
            wm.Time = list[0].Time;


            WeatherInfo wi = new WeatherInfo(wm);
            return wi;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            updateFavourite();
        }
    }
}