﻿using System;
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
using System.IO;
using leren.Algemeen;
namespace leren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class leerkrachtVenster : Window
    {
        public leerkrachtVenster()
        {
            InitializeComponent();
            GebruikersLijst lijst = new GebruikersLijst("student");           
            Combobox1.ItemsSource = lijst.Naam;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void combobox1(object sender, RoutedEventArgs e)
        {
        //    try
        //    {
               
        //      StreamReader sr = new StreamReader ("C:\Users\11400126\Desktop");

        //        string line = sr.ReadLine();

        //        while (line != null)
        //        {
        //            Console.WriteLine(line);
        //        }
        //    }
                
               
        //        catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
            
        }
    }
}
