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
    /// Логика взаимодействия для ProductIngredient.xaml
    /// </summary>
    public partial class ProductIngredient : Page
    {
        public ProductIngredient()
        {
            InitializeComponent();
            ProDG.ItemsSource = Conn.context.ProductIngredients.ToList();
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddProductIngredient((sender as Button).DataContext as ProductIngredients));
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddProductIngredient(null));
        }

        private void Obnbtn_Click(object sender, RoutedEventArgs e)
        {
            ProDG.ItemsSource = Conn.context.ProductIngredients.ToList();
        }

        private void Delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delpos = ProDG.SelectedItems.Cast<ProductIngredients>().ToList();
            if (MessageBox.Show($"Удалить {delpos.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Conn.context.ProductIngredients.RemoveRange((IEnumerable<AppData.ProductIngredients>)delpos);
            try
            {
                Conn.context.SaveChanges();
                ProDG.ItemsSource = Conn.context.ProductIngredients.ToList();
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
            ProDG.ItemsSource = Conn.context.ProductIngredients.Where(x => x.ProductID.ToString().StartsWith(Poisktb.Text)).ToList();
        }
    }
}
