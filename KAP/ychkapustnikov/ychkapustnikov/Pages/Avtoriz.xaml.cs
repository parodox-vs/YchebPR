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
    /// Логика взаимодействия для Avtoriz.xaml
    /// </summary>
    public partial class Avtoriz : Page
    {
        public Avtoriz()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (T.Text != "" || T1.Text != "")
            {
                MessageBox.Show("Неправильно введен логин или пароль");
            }
            else
            {
                Class1.MainFrame.Navigate(new Kopya());
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Avtoriz2());
        }
    }
}
