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

namespace Examen
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Page
    {
        PrimerEntities Context;
        public Client()
        {
            InitializeComponent();
        
            Context = new PrimerEntities();
            DTGridClient.ItemsSource = Context.Person.ToList();
            CmbGender.ItemsSource = Context.Gender.ToList();

           
        }

        private void CmbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            Filter();
           
        }
        public void Filter()
        {
            Gender CurrentGender = CmbGender.SelectedItem as Gender;
            List<Person> Persons = Context.Person.ToList();
            Persons = Persons.Where(d => d.Gender == CurrentGender).ToList();
            Persons = Persons.Where(d => d.LastName.ToLower().Contains(TxtFirstName.Text.ToLower())).ToList(); 
            DTGridClient.ItemsSource = Persons;

           
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEdit((sender as Button).DataContext as Person));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            
            var ClientForRemoving = DTGridClient.SelectedItems.Cast<Person>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {ClientForRemoving.Count()}элементов ?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PrimerEntities.GetContext().Person.RemoveRange(ClientForRemoving);
                    PrimerEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены! ");
                    DTGridClient.ItemsSource = PrimerEntities.GetContext().Person.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEdit(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PrimerEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DTGridClient.ItemsSource = PrimerEntities.GetContext().Person.ToList();
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            CmbGender.SelectedIndex = -1;
            TxtFirstName.Text = "";
            DTGridClient.ItemsSource = PrimerEntities.GetContext().Person.ToList();
        }
    }
}
