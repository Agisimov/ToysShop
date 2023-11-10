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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnVhod_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                MessageBox.Show("логин не может быть пустым ");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("пароль не может быть пустым "); return;
            }


            var ayth = context.Employee.ToList().Where(i => i.Login == tbLogin.Text).FirstOrDefault();
            if (ayth != null)
            {
                ClassHelper.AUF.employee = ayth;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("нет такого пользователя");
                return;
            }
        



        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Close();
        }
    }
}
