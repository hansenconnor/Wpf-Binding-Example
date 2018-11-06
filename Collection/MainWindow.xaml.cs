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

namespace Collection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> _people;
        public MainWindow()
        {
            InitializeComponent();

            _people = new ObservableCollection<Person>
            {
                new Person {Name = "connor", Age = 22 },
                new Person {Name = "connor", Age = 22 },
                new Person {Name = "connor", Age = 22 },
                new Person {Name = "connor", Age = 22 },
                new Person {Name = "connor", Age = 22 }
            };

            _list.ItemsSource = _people;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            _people.Add(new Person { Name = "Connor", Age = 22 });
        }
    }
}
