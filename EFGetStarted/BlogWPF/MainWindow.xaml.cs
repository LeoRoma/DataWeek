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
            ListBoxBlogs.ItemsSource = _bm.ReadBlog();
            //ListBoxPosts.ItemsSource = _bm.ReadPost();
        }

        private void ButtonDeleteBlog_Click(object sender, RoutedEventArgs e)
        {
            _bm.Delete();
            ListBoxBlogs.ItemsSource = _bm.ReadBlog();
        }

        private void PopulateListBox()
        {
            ListBoxBlogs.ItemsSource = _bm.ReadBlog();
           
        }

        private void ListBoxBlogs_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ListBoxBlogs.SelectedItem != null)
            {
                _bm.SetSelectedBlogs(ListBoxBlogs.SelectedItem);
                PopulatePost();
            }
        }

        private void ListBoxPosts_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ListBoxPosts.SelectedItem != null)
            {
                _bm.SetSelectedPosts(ListBoxPosts.SelectedItem);
                PopulatePost();
            }
        }

        private void ButtonEditBlog_Click(object sender, RoutedEventArgs e)
        {
            string userInput = MyTextBox.Text;
            _bm.Edit(userInput);
            MyTextBox.Clear();
            
            ListBoxBlogs.SelectedItem = _bm.SelectedBlog;
            ListBoxBlogs.ItemsSource = _bm.ReadBlog();
        }

        private void PopulatePost()
        {
            if (_bm.SelectedBlog != null)
            {
                //TextId.Text = _crudManager.SelectedCustomer.CustomerId;
                //TextName.Text = _crudManager.SelectedCustomer.ContactName;
                //TextCity.Text = _crudManager.SelectedCustomer.City;
                //TextPostalCode.Text = _crudManager.SelectedCustomer.PostalCode;
                //TextCountry.Text = _crudManager.SelectedCustomer.Country;
                ListBoxPosts.ItemsSource = _bm.ReadPost(_bm.SelectedBlog.BlogId);
            }
        }

        private void ButtonAddPost_Click(object sender, RoutedEventArgs e)
        {
            string userTitle = PostTitle.Text;
            string userContent = PostContent.Text;
            _bm.Update(userTitle, userContent);
            MyTextBox.Clear();

            ListBoxBlogs.SelectedItem = _bm.SelectedBlog;
            ListBoxPosts.ItemsSource = _bm.ReadPost(_bm.SelectedBlog.BlogId);
        }

        private void ButtonDeletePost_Click(object sender, RoutedEventArgs e)
        {
            _bm.DeletePost(_bm.SelectedPost.PostId);
            PopulatePost();
        }
    }
}
