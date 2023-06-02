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
    /// Логика взаимодействия для animal4.xaml
    /// </summary>
    public partial class animal4 : Page
    {
        public animal4()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/animal3.xaml", UriKind.Relative));
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/animal5.xaml", UriKind.Relative));
        }
    }
}
