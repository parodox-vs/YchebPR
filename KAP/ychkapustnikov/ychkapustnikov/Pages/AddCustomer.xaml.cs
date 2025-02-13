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
    /// Логика взаимодействия для AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Page
    {
        Customers cust;
        bool check;

        public AddCustomer(Customers c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new Customers();
                check = true;
            }
            else
                check = false;
            DataContext = cust = c;
        }

        private void ADDBtn_Click(object sender, RoutedEventArgs e)
        {
            if (check)
            {
                Conn.context.Customers.Add(cust);
            }
            try
            {
                Conn.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Class1.MainFrame.GoBack();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.GoBack();
        }
    }
}
