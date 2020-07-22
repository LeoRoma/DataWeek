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
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            string userInput = MyTextBox.Text;
            _bm.Add(userInput);
            MyTextBox.Clear();
            LabelDisplay.Content = _bm.Read();
        }

        private void ButtonRead_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content = _bm.Read();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            string userInput = MyTextBox.Text;
            _bm.Delete(userInput);
            MyTextBox.Clear();
            LabelDisplay.Content = _bm.Read();
        }

    }
}
