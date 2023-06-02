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

namespace wild_animals
{
    /// <summary>
    /// Логика взаимодействия для animal1.xaml
    /// </summary>
    public partial class animal1 : Page
    {
        public animal1()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/animal2.xaml", UriKind.Relative));
        }
    }
}
