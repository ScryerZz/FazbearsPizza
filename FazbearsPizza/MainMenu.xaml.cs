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

namespace FazbearsPizza
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void OpenPizeria_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Pizzeria());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
        }

        private void DoubleAnimation_Completed_OpPiz(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Pizzeria());
        }

        private void DoubleAnimation_Completed_Ex(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
