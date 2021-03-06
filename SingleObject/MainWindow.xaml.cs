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

namespace SingleObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person _person;
        public MainWindow()
        {
            InitializeComponent();

            _person = new Person { Name = "Connor", Age = 22 };
            DataContext = _person;
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            _person.Age++;
        }
    }
}
