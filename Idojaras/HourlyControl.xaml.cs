using Idojaras.WeatherApi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Idojaras
{
    /// <summary>
    /// Interaction logic for HourlyControl.xaml
    /// </summary>
    public partial class HourlyControl : UserControl
    {
        public HourlyControl()
        {
            InitializeComponent();
            Root.DataContext = this;
        }


        public ObservableCollection<WeatherInfo> Measurement
        {
            get { return (ObservableCollection<WeatherInfo>)GetValue(MeasurementProperty); }
            set { SetValue(MeasurementProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Measurement.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MeasurementProperty =
            DependencyProperty.Register("Measurement", typeof(ObservableCollection<WeatherInfo>), typeof(HourlyControl), new PropertyMetadata(new ObservableCollection<WeatherInfo>()));
        
    }

    
    
}