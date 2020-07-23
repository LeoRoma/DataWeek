using System.Windows;
using CodeFromNorthwindBusiness;

namespace NorthWindWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CRUDManager _crudManager = new CRUDManager();
        public MainWindow()
        {
            InitializeComponent();
            PopulateListBox();
        }
        private void PopulateListBox()
        {
            ListBoxCustomer.ItemsSource = _crudManager.RetrieveAll();
        }

        private void PopulateCustomerFields()
        {
            if (_crudManager.SelectedCustomer != null)
            {
                TextId.Text = _crudManager.SelectedCustomer.CustomerId;
                TextName.Text = _crudManager.SelectedCustomer.ContactName;
                TextCity.Text = _crudManager.SelectedCustomer.City;
                TextPostalCode.Text = _crudManager.SelectedCustomer.PostalCode;
                TextCountry.Text = _crudManager.SelectedCustomer.Country;
            }
        }

        private void ListBoxCustomer_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ListBoxCustomer.SelectedItem != null)
            {
                _crudManager.SetSelectedCustomer(ListBoxCustomer.SelectedItem);
                PopulateCustomerFields();
            }
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.Update(TextId.Text, TextName.Text, TextCity.Text, TextPostalCode.Text, TextCountry.Text);
            ListBoxCustomer.ItemsSource = null;
            // put back the screen data
            PopulateListBox();
            ListBoxCustomer.SelectedItem = _crudManager.SelectedCustomer;
            PopulateCustomerFields();
        }
    }
}
