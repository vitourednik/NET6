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
using Playground.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            PeopleDataset.GeneratePeople(20);
            dgDataset.ItemsSource = PeopleDataset.People;
            //txbInfo.Text = "";
            //foreach (var osoba in PeopleDataset.People)
            //{
            //    txbInfo.Text += osoba.ToString() + Environment.NewLine;
            //}
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            var person = (Person)dgDataset.SelectedItem;

            if (person != null)
            {
                //otevri okno
                PersonDetailWindow pdw = new PersonDetailWindow(person);
                pdw.Show();
                
            }
            else
            {
                //nema nic vybraneho
            }

        }

        private async void btnLoadApi_Click(object sender, RoutedEventArgs e)
        {
            await PeopleDataset.LoadPeopleFromAPI(5);
            dgDataset.ItemsSource = PeopleDataset.People;
        }
    }
}
