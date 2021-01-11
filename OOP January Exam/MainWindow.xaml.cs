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

namespace OOP_January_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Account> accounts;  //collection to contain all accounts
        public List<Account> filteredAccounts;  //collection used for filtering 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Initialise the collections
            accounts = new List<Account>();
            filteredAccounts = new List<Account>();

            //Create some part time and full time employees
            CurrentAccount ca1 = new CurrentAccount() { FirstName = "John", LastName = "Smith", Balance = 250, AccountNumber = 1};
            SavingsAccount sa1 = new SavingsAccount() { FirstName = "Jess", LastName = "Walsh", Balance = 5000, AccountNumber = 2 };

            //Add all employees to main colelction of employees
            accounts.Add(ca1);
            accounts.Add(sa1);

            UpdateListBox(accounts);// Call method to sort list and update display

            //Set initial values on checkboxes
            cacbx.IsChecked = true;
            sacbx.IsChecked = true;
        }

        //Method to update the listbox with the details of the list passed to it
        private void UpdateListBox(List<Account> accounts)
        {
            //Refreshes the display
            Accountslbx.ItemsSource = null;
            Accountslbx.ItemsSource = accounts;
        }
    }
}
