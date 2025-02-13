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
using ychkapustnikov.AppData;

namespace ychkapustnikov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Customer());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Ingridient());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new PozZakaz());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Order());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new ProductIngredient());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Product());
        }
    }
}
