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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbname.Text))
            {
                MessageBox.Show("имя не может быть пустым");
                return;

            }
            if (string.IsNullOrWhiteSpace(tbcost.Text))
            {
                MessageBox.Show("цена не может быть пустым");
                return;

            }

            DB.Product product = new Product();
            product.Title = tbname.Text;
            product.Cost = Convert.ToDecimal(tbcost.Text);
            context.Product.Add(product);
            context.SaveChanges();
            MessageBox.Show("окк");

            Windows.Prod prod = new Prod();
            prod.Show();
            this.Close();
            


        }
    }
}
