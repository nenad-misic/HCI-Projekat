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

namespace Idojaras
{
    /// <summary>
    /// Interaction logic for SearchControl.xaml
    /// </summary>
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();

            Root.DataContext = this;
        }


        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public string MinTemp
        {
            get { return (string)GetValue(MinTempProperty); }
            set { SetValue(MinTempProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinTemp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinTempProperty =
            DependencyProperty.Register("MinTemp", typeof(string), typeof(SearchControl), new PropertyMetadata(""));


    }
}
