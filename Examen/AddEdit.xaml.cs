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
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Page
    {
        private Person _currentPerson = new Person();
        public AddEdit(Person SelectPerson)
        {
            InitializeComponent();
            if (SelectPerson != null)
            {
                _currentPerson = SelectPerson;
            }
            DataContext = _currentPerson;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(_currentPerson.FirstName))

                errors.AppendLine("Укажите Имя");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentPerson.ID == 0)
                PrimerEntities.GetContext().Person.Add(_currentPerson);

            try
            {
                PrimerEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                this.NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
