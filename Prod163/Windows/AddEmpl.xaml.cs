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

namespace Prod163.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEmpl.xaml
    /// </summary>
    public partial class AddEmpl : Window
    {
        public AddEmpl()
        {
            InitializeComponent();
            cmPost.ItemsSource = context.Post.ToList();
            cmPost.SelectedIndex = 0;
            cmPost.DisplayMemberPath = "Title";



        }

        private void btnVhod_Click(object sender, RoutedEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(tbFname.Text))
            {
                MessageBox.Show("имя не может быть пустым"); return;
            }

            if (string.IsNullOrWhiteSpace(tbLname.Text))
            {
                MessageBox.Show("фамилия не может быть пустым"); return;
            }

            if (string.IsNullOrWhiteSpace(tbPatrname.Text))
            {
                MessageBox.Show("отчество не может быть пустым"); return;
            }

            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                MessageBox.Show("логин не может быть пустым"); return;
            }

            if (string.IsNullOrWhiteSpace(tbPass.Text))
            {
                MessageBox.Show("пароль не может быть пустым"); return;
            }

            if (string.IsNullOrWhiteSpace(cmPost.Text))
            {
                MessageBox.Show("должность не может быть пустым"); return;
            }

            if (string.IsNullOrWhiteSpace(data.Text))
            {
                MessageBox.Show("дата не может быть пустым");
                return;
            }

            var auth = context.Employee.ToList().Where(i => i.Login == tbLogin.Text).FirstOrDefault();
            if (auth != null)
            {
                MessageBox.Show("логин занят");
                return;
            }

            DB.Employee employee = new DB.Employee();
            employee.FName = tbFname.Text;
            employee.LName = tbLname.Text;
            employee.MName = tbPatrname.Text;
            employee.Login = tbLogin.Text;
            employee.Password = tbPass.Text;
            employee.DateOfBirthday = data.SelectedDate.Value;
            employee.IdPost = (cmPost.SelectedItem as Post).Id;
            context.Employee.Add(employee);
            context.SaveChanges();
            MessageBox.Show("без б ");
            Windows.Employee employee1 = new Employee();
            employee1.Show();
            this.Close();


        }
    }
}
