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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = TxtLogin.Text;
            string pass = TxtPass.Text;
            Users AuthUser = null;
            AuthUser = DEEntities.GetContext().Users.Where(b=>b.Login == login && b.Password == pass).FirstOrDefault();

            if (AuthUser != null)
            {
                int Role = (int)AuthUser.Role_Id;
                NavigationService.Navigate(new ViewPage());
                MessageBox.Show(Role.ToString());
            }
        }
    }
}
