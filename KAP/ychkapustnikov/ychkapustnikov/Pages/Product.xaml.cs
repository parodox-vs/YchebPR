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
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        public Product()
        {
            InitializeComponent();
            ProdDG.ItemsSource = Conn.context.Products.ToList();
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddProduct((sender as Button).DataContext as Products));
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddProduct(null));
        }

        private void Obnbtn_Click(object sender, RoutedEventArgs e)
        {
            ProdDG.ItemsSource = Conn.context.Products.ToList();
        }

        private void Delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delpos = ProdDG.SelectedItems.Cast<Products>().ToList();
            if (MessageBox.Show($"Удалить {delpos.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Conn.context.Products.RemoveRange((IEnumerable<AppData.Products>)delpos);
            try
            {
                Conn.context.SaveChanges();
                ProdDG.ItemsSource = Conn.context.Products.ToList();
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
            ProdDG.ItemsSource = Conn.context.Products.Where(x => x.Name.StartsWith(Poisktb.Text)).ToList();
        }
    }
}
