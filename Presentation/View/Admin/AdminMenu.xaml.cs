using ARMDel.Presentation.View.Admin;
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

namespace ARMDel.Presentation.View
{
    /// <summary>
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AddСourier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddOperator_Click(object sender, RoutedEventArgs e)
        {
            AddingOperator addingOperator = new AddingOperator();
            this.Close();
            addingOperator.Show();
        }


        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddingProduct addingProduct = new AddingProduct();
            this.Close();
            addingProduct.Show();
        }

        private void ChangeProduct_Click(object sender, RoutedEventArgs e)
        {
            ChangeProductPrice chp = new ChangeProductPrice();
            this.Close();
            chp.Show();
        }

        private void AddNewDistrict_Click(object sender, RoutedEventArgs e)
        {
            AddDistrict addDistrict = new AddDistrict();
            this.Close();
            addDistrict.Show();
        }

        private void ChangeDistrict_Click(object sender, RoutedEventArgs e)
        {
            ChangeDelPrice delPrise = new ChangeDelPrice();
            this.Close();
            delPrise.Show();
        }
    }
}
