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

            //Create some current accounts and savings accounts
            CurrentAccount ca1 = new CurrentAccount() { FirstName = "John", LastName = "Smith", Balance = 250, AccountNumber = 1};
            SavingsAccount sa1 = new SavingsAccount() { FirstName = "Jess", LastName = "Walsh", Balance = 5000, AccountNumber = 2 };

            //Add all accounts to main colelction of accounts
            accounts.Add(ca1);
            accounts.Add(sa1);

            UpdateListBox(accounts);// Call method to sort list and update display

            //Set initial values on checkboxes
            cacbx.IsChecked = true;
            sacbx.IsChecked = true;
        }

        //Used to filter by full time and part time employees
        private void Chbx_Click(object sender, RoutedEventArgs e)
        {

            //all employees
            if ((cacbx.IsChecked == true) && (sacbx.IsChecked == true))
                UpdateListBox(accounts);

            //no employees
            else if ((cacbx.IsChecked == false) && (sacbx.IsChecked == false))
                Accountslbx.ItemsSource = null;

            //Full time employees
            else if ((cacbx.IsChecked == true) && (sacbx.IsChecked == false))
            {
                filteredAccounts.Clear();

                foreach (Account account in accounts)
                {
                    if (account is CurrentAccount)
                        filteredAccounts.Add(account);
                }

                UpdateListBox(filteredAccounts);
            }

            //Part time employees
            else if ((cacbx.IsChecked == false) && (sacbx.IsChecked == true))
            {
                filteredAccounts.Clear();

                foreach (Account account in accounts)
                {
                    if (account is SavingsAccount)

                        filteredAccounts.Add(account);
                }

                UpdateListBox(filteredAccounts);
            }

        }

        //Method to update the listbox with the details of the list passed to it
        private void UpdateListBox(List<Account> accounts)
        {
            //Refreshes the display
            Accountslbx.ItemsSource = null;
            Accountslbx.ItemsSource = accounts;
        }

        //Method to print account data when selected from listbox
        private void Accountslbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Account selected = Accountslbx.SelectedItem as Account;

            if (selected != null)
            {
                fntxblk1.Text = selected.FirstName;
                lntxblk.Text = selected.LastName;
                perbalancetxblk.Text = selected.Balance.ToString();

                if (selected is CurrentAccount)
                {
                    accounttxblk.Text = "Current Account";
                }
                else if (selected is SavingsAccount)
                {
                    accounttxblk.Text = "Savings Account";
                }
            }
        }

        //clears transaction textbox when clicked on
        private void transactiontbx_GotFocus(object sender, RoutedEventArgs e)
        {
            transactiontbx.Clear();
        }

        private void depositbtn_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = Convert.ToDecimal(transactiontbx.Text);
            Deposit();
        }

        private void withdrawbtn_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = Convert.ToDecimal(transactiontbx.Text);
            Withdraw();
        }

        private void interestbtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
