using Idojaras.WeatherApi;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for SingleHourControl.xaml
    /// </summary>
    public partial class SingleHourControl : UserControl
    {
        public SingleHourControl()
        {
            InitializeComponent();
            Root.DataContext = this;
        }



        public WeatherInfo Measurement
        {
            get { return (WeatherInfo)GetValue(MeasurementProperty); }
            set { SetValue(MeasurementProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Measurement.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MeasurementProperty =
            DependencyProperty.Register("Measurement", typeof(WeatherInfo), typeof(SingleHourControl), new PropertyMetadata(new WeatherInfo()));
        
    }
}
