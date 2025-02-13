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
    /// Логика взаимодействия для PozZakaz.xaml
    /// </summary>
    public partial class PozZakaz : Page
    {
        public PozZakaz()
        {
            InitializeComponent();
            PozDG.ItemsSource = Conn.context.OrderItems.ToList();
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddPozZakaz((sender as Button).DataContext as OrderItems));
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddPozZakaz(null));
        }

        private void Obnbtn_Click(object sender, RoutedEventArgs e)
        {
            PozDG.ItemsSource = Conn.context.OrderItems.ToList();
        }

        private void Delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delpos = PozDG.SelectedItems.Cast<OrderItems>().ToList();
            if (MessageBox.Show($"Удалить {delpos.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Conn.context.OrderItems.RemoveRange((IEnumerable<AppData.OrderItems>)delpos);
            try
            {
                Conn.context.SaveChanges();
                PozDG.ItemsSource = Conn.context.OrderItems.ToList();
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
            PozDG.ItemsSource = Conn.context.OrderItems.Where(x => x.OrderID.ToString().StartsWith(Poisktb.Text)).ToList();
        }
    }
}
