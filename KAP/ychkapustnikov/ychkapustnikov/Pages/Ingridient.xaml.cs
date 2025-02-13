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
    /// Логика взаимодействия для Ingridient.xaml
    /// </summary>
    public partial class Ingridient : Page
    {
        public Ingridient()
        {
            InitializeComponent();
            IngDG.ItemsSource = Conn.context.Ingredients.ToList();
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddIngridient((sender as Button).DataContext as Ingredients));
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddIngridient(null));
        }

        private void Obnbtn_Click(object sender, RoutedEventArgs e)
        {
            IngDG.ItemsSource = Conn.context.Ingredients.ToList();
        }

        private void Delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delpos = IngDG.SelectedItems.Cast<Ingredients>().ToList();
            if (MessageBox.Show($"Удалить {delpos.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Conn.context.Ingredients.RemoveRange((IEnumerable<AppData.Ingredients>)delpos);
            try
            {
                Conn.context.SaveChanges();
                IngDG.ItemsSource = Conn.context.Ingredients.ToList();
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

        private void Zaprbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
