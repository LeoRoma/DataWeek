using System;
using System.Collections.Generic;
using System.Data;
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
            ListBoxBlogs.ItemsSource = _bm.Read();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            _bm.Delete();
            MyTextBox.Clear();
            ListBoxBlogs.ItemsSource = _bm.Read();
        }

        private void PopulateListBox()
        {
            ListBoxBlogs.ItemsSource = _bm.Read();
        }

        private void ListBoxBlogs_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ListBoxBlogs.SelectedItem != null)
            {
                _bm.SetSelectedBlogs(ListBoxBlogs.SelectedItem);
                PopulateCustomerFields();
            }
        }

        private void PopulateCustomerFields()
        {
            if (_bm.SelectedBlog != null)
            {
                //TextId.Text = _crudManager.SelectedCustomer.CustomerId;
                //TextName.Text = _crudManager.SelectedCustomer.ContactName;
                //TextCity.Text = _crudManager.SelectedCustomer.City;
                //TextPostalCode.Text = _crudManager.SelectedCustomer.PostalCode;
                //TextCountry.Text = _crudManager.SelectedCustomer.Country;
            }
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            string userInput = MyTextBox.Text;
            _bm.Edit(userInput);
            MyTextBox.Clear();
            ListBoxBlogs.ItemsSource = _bm.Read();
        }
    }
}
