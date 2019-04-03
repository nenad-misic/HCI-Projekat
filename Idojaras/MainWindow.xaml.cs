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
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public delegate int onCardClicked();
    public partial class MainWindow : Window
    {
        public string MiniTemp { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MiniTemp = "15°/";
            this.DataContext = this;
        }
        
        
        
    }
}
