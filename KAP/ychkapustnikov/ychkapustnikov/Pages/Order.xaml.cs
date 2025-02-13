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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;
using Button = System.Windows.Controls.Button;

namespace ychkapustnikov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Page
    {
        public Order()
        {
            InitializeComponent();
            OrdDG.ItemsSource = Conn.context.Orders.ToList();
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddOrder((sender as Button).DataContext as Orders));
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new AddOrder(null));
        }

        private void Obnbtn_Click(object sender, RoutedEventArgs e)
        {
            OrdDG.ItemsSource = Conn.context.Orders.ToList();
        }

        private void Delbtn_Click(object sender, RoutedEventArgs e)
        {
            var delpos = OrdDG.SelectedItems.Cast<Orders>().ToList();
            if (MessageBox.Show($"Удалить {delpos.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Conn.context.Orders.RemoveRange((IEnumerable<AppData.Orders>)delpos);
            try
            {
                Conn.context.SaveChanges();
                OrdDG.ItemsSource = Conn.context.Orders.ToList();
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

        private void Otcbtn_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            Workbook workBook = app.Workbooks.Add(Type.Missing);
            Worksheet w = app.Worksheets.get_Item(1);
            var proda = Conn.context.Orders.ToList();
            int curRow = 1;
            foreach (var item in proda)
            {
                w.Cells[curRow, 1].Value = item.OrderID.ToString();
                w.Cells[curRow, 2].Value = item.CustomerID.ToString();
                w.Cells[curRow, 3].Value = item.OrderDate.ToString();
                w.Cells[curRow, 4].Value = item.TotalAmount.ToString();
                w.Cells[curRow, 5].Value = item.OrderStatus.ToString();
                w.Cells[curRow, 6].Value = item.PhoneNumber.ToString();

                curRow++;
            }
            app.Quit();
        }
    }
}
