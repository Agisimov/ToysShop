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
using System.Windows.Shapes;
using Prod163.DB;
using static Prod163.ClassHelper.AUF;
using static Prod163.ClassHelper.EFClass;

namespace Prod163.Windows
{
    /// <summary>
    /// Логика взаимодействия для Prod.xaml
    /// </summary>
    public partial class Prod : Window
    {
        public Prod()
        {
            InitializeComponent();

            ListProd.ItemsSource = context.Product.ToList();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


        private void add_Click(object sender, RoutedEventArgs e)
        {
            Windows.Add add = new Add();
            add.Show();
            this.Close();
        }
    }
}
