﻿using Idojaras.Models;
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
using static Idojaras.MainContent;

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




        public List<City> Cities
        {
            get { return (List<City>)GetValue(CitiesProperty); }
            set { SetValue(CitiesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Cities.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CitiesProperty =
            DependencyProperty.Register("Cities", typeof(List<City>), typeof(SearchControl), new PropertyMetadata(null));

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var cmbx = sender as ComboBox;
            cmbx.ItemsSource = from item in this.Cities
                               where item.Name.ToLower().Contains(cmbx.Text.ToLower())
                               select item;
            cmbx.IsDropDownOpen = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            searchClicked(Convert.ToInt32(((City)cmbx.SelectedItem).Id));
        }





        public onSearchClicked searchClicked
        {
            get { return (onSearchClicked)GetValue(searchClickedProperty); }
            set { SetValue(searchClickedProperty, value); }
        }


        // Using a DependencyProperty as the backing store for searchClicked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty searchClickedProperty =
            DependencyProperty.Register("searchClicked", typeof(onSearchClicked), typeof(SearchControl), new PropertyMetadata(null));




    }
}
