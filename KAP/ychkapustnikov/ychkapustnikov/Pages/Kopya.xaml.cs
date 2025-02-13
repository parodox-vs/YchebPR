using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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
    /// Логика взаимодействия для Kopya.xaml
    /// </summary>
    public partial class Kopya : Page
    {
        public Kopya()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Резервная копия(*.bak)|*.bak|Все файлы(*.*)|*.*";
            bool? result = dialog.ShowDialog();
            if (result == true)
                Conn.context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
            $@"BACKUP DATABASE [{Directory.GetCurrentDirectory()}\practica.mdf] TO  " +
            $@"DISK = N'{dialog.FileName}' WITH NOFORMAT, NOINIT,  " +
             $@"NAME = N'{dialog.FileName}', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Class1.MainFrame.Navigate(new Main());
        }
    }
}
