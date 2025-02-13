using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ychkapustnikov.AppData;
using ychkapustnikov.Pages;

namespace ychkapustnikov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Customer.xaml
    /// </summary>
    public partial class Customer : Page
    {
        public Customer()
        {
            InitializeComponent();
            CustDG.ItemsSource = Conn.context.Customers.ToList();  
        }

  

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddCustomer((sender as Button).DataContext as Customers));
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddCustomer(null));
        }

        private void Obnbtn_Click(object sender, RoutedEventArgs e)
        {
            CustDG.ItemsSource = Conn.context.Customers.ToList();
        }

        private void Delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delpos = CustDG.SelectedItems.Cast<Customers>().ToList();
            if (MessageBox.Show($"Удалить {delpos.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Conn.context.Customers.RemoveRange((IEnumerable<AppData.Customers>)delpos);
            try
            {
                Conn.context.SaveChanges();
                CustDG.ItemsSource = Conn.context.Customers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.GoBack();
        }

        private void Poisktb_TextChanged(object sender, TextChangedEventArgs e)
        {
            CustDG.ItemsSource = Conn.context.Customers.Where(x => x.LastName.StartsWith(Poisktb.Text)).ToList();
        }

      
    }
}
