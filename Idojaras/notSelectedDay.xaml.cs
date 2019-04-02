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
    /// Interaction logic for notSelectedDay.xaml
    /// </summary>
    public partial class notSelectedDay : UserControl
    {
        public notSelectedDay()
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
            DependencyProperty.Register("Measurement", typeof(WeatherInfo), typeof(notSelectedDay), new PropertyMetadata(new WeatherInfo()));

        

        public onCardClicked onCardClickedFun
        {
            get { return (onCardClicked)GetValue(onCardClickedFunProperty); }
            set { SetValue(onCardClickedFunProperty, value); }
        }

        // Using a DependencyProperty as the backing store for onCardClickedFun.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty onCardClickedFunProperty =
            DependencyProperty.Register("onCardClickedFun", typeof(onCardClicked), typeof(notSelectedDay), new PropertyMetadata());

        

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.onCardClickedFun();
        }
    }
}
