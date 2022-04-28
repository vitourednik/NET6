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
using Playground.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PersonDetailWindow.xaml
    /// </summary>
    public partial class PersonDetailWindow : Window
    {
        public PersonDetailWindow(Person person)
        {
            InitializeComponent();
            txtAddress.Text = person.Address.ToString();
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtDateOfBirth.Text = person.DateOfBirth.ToString();
        }
    }
}
