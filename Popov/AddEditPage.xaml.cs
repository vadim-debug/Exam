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

namespace Popov
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Orders CurrentOrder = new Orders();
        public AddEditPage(Orders selectedOrder)
        {
            InitializeComponent();
            if(selectedOrder != null)
                CurrentOrder = selectedOrder;

            DataContext = CurrentOrder;
            CmbUser.ItemsSource = DEEntities.GetContext().Users.ToList();
            CmbProd.ItemsSource = DEEntities.GetContext().Product.ToList();

        
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
           if(CurrentOrder.Id ==0)     
           DEEntities.GetContext().Orders.Add(CurrentOrder);

            try
            {
                DEEntities.GetContext().SaveChanges();
                MessageBox.Show("информация сохранена");
                NavigationService.GoBack();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
