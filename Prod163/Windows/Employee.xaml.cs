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
using static Prod163.ClassHelper.EFClass;

using static Prod163.ClassHelper.AUF;

namespace Prod163.Windows
{
    /// <summary>
    /// Логика взаимодействия для Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        public Employee()
        {
            InitializeComponent();

            gridEmpl.ItemsSource = context.Employee.ToList();

          var emp = context.Employee.ToList();
            
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddEmpl add = new AddEmpl();
            add.Show();
            this.Close();
        }

        private void edd_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("изменено");
        }
    }
}
