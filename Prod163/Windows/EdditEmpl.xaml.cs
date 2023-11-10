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
using static Prod163.ClassHelper.AUF;
using static Prod163.ClassHelper.EFClass;
using Prod163.DB;
using Prod163.ClassHelper;

namespace Prod163.Windows
{
    /// <summary>
    /// Логика взаимодействия для EdditEmpl.xaml
    /// </summary>
    public partial class EdditEmpl : Window
    {
        public EdditEmpl()
        {
            InitializeComponent();


            cmPol.ItemsSource = context.Gender.ToList();
            cmPol.SelectedIndex = 0;
            cmPol.DisplayMemberPath = "Title";
            cmPost.ItemsSource = context.Post.ToList();
            cmPost.SelectedIndex = 0;
            cmPost.DisplayMemberPath = "Title";
        }

        private void btnVhod_Click(object sender, RoutedEventArgs e)
        {
         



        }
    }
}
