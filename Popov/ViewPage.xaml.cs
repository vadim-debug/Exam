using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using System.Xml.Linq;

namespace Popov
{
    /// <summary>
    /// Логика взаимодействия для ViewPage.xaml
    /// </summary>
    public partial class ViewPage : Page
    {
        public ViewPage()
        {
            InitializeComponent();
            cmbProduct.ItemsSource = DEEntities.GetContext().Product.ToList();
          
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPage((sender as Button).DataContext as Orders));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DEEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGridOrders.ItemsSource = DEEntities.GetContext().Orders.ToList();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var OrdersForRemoving = DGridOrders.SelectedItems.Cast<Orders>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {OrdersForRemoving.Count()}элементов ?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DEEntities.GetContext().Orders.RemoveRange(OrdersForRemoving);
                    DEEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridOrders.ItemsSource = DEEntities.GetContext().Orders.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
           
            NavigationService.Navigate(new AddEditPage(null));
        }

        private void cmbProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }
        public void Filter() 
        {
            Product CurrentProduct = cmbProduct.SelectedItem as Product;
            List<Orders> orders = DEEntities.GetContext().Orders.ToList();
            orders = orders.Where(d => d.Product == CurrentProduct).ToList();
            orders = orders.Where(d => d.Name.ToLower().Contains(txtName.Text.ToLower())).ToList();
            DGridOrders.ItemsSource = orders;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            cmbProduct.SelectedIndex= -1;
            DEEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGridOrders.ItemsSource = DEEntities.GetContext().Orders.ToList();
        }
    }
}
