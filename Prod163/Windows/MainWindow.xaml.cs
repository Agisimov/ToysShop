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
using static Prod163.ClassHelper.AUF;
using static Prod163.ClassHelper.EFClass;
using Prod163.DB;


namespace Prod163
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tbpriv.Text ="Добро пожаловать OG," + ClassHelper.AUF.employee.FName;
        }

        private void btnProd_Click(object sender, RoutedEventArgs e)
        {
            Windows.Prod prod = new Windows.Prod();
            prod.Show();
            this.Close();
        }

        private void btnEmp_Click(object sender, RoutedEventArgs e)
        {
            Windows.Employee employee = new Windows.Employee();
            employee.Show();
            this.Close();
        }

        private void btnOrd_Click(object sender, RoutedEventArgs e)
        {
            Windows.Ord ord = new Windows.Ord();
            ord.Show();
            this.Close();
        }
    }
}
