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
using BlogApp;

namespace BlogWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BlogManager _bm = new BlogManager();

        public MainWindow()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            string userInput = MyTextBox.Text;
            _bm.Add(userInput);
            MyTextBox.Clear();
            ListBoxCustomer.ItemsSource = _bm.Read();
        }

        private void ButtonRead_Click(object sender, RoutedEventArgs e)
        {
            ListBoxCustomer.ItemsSource = _bm.Read();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            string userInput = MyTextBox.Text;
            _bm.Delete(userInput);
            MyTextBox.Clear();
            ListBoxCustomer.ItemsSource = _bm.Read();
        }

        private void PopulateListBox()
        {
            ListBoxCustomer.ItemsSource = _bm.Read();
        }

        private void ListBoxCustomer_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ListBoxCustomer.SelectedItem != null)
            {
                _bm.SetSelectedCustomer(ListBoxCustomer.SelectedItem);
                PopulateCustomerFields();
            }
        }

        private void PopulateCustomerFields()
        {
            if (_bm.SelectedCustomer != null)
            {
                //TextId.Text = _crudManager.SelectedCustomer.CustomerId;
                //TextName.Text = _crudManager.SelectedCustomer.ContactName;
                //TextCity.Text = _crudManager.SelectedCustomer.City;
                //TextPostalCode.Text = _crudManager.SelectedCustomer.PostalCode;
                //TextCountry.Text = _crudManager.SelectedCustomer.Country;
            }
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
