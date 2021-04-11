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

namespace Painters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtWall4_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name needs an input", "Blank Warning!");
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email input required", "Blank Warning!");
            }
            if (string.IsNullOrEmpty(txtHeight.Text))
            {
                MessageBox.Show("Height value required", "Blank Warning!");
            }
            if (string.IsNullOrEmpty(txtWall1.Text))
            {
                MessageBox.Show("Wall 1 value required", "Blank Warning!");
            }
            if (string.IsNullOrEmpty(txtWall2.Text))
            {
                MessageBox.Show("Wall 2 value required", "Blank Warning!");
            }
            if (string.IsNullOrEmpty(txtWall3.Text))
            {
                MessageBox.Show("Wall 3 value required", "Blank Warning!");
            }
            if (string.IsNullOrEmpty(txtWall4.Text))
            {
                MessageBox.Show("Wall 4 value required", "Blank Warning!");
            }
            int parsedValue;
            if (!int.TryParse(txtISBN.Text, out parsedValue))
            {
                MessageBox.Show("ISBN should be Numberical", "Value Type Warning");
                return;
            }
            if (!int.TryParse(txtPage.Text, out parsedValue))
            {
                MessageBox.Show("Page should be Numberical", "Value Type Warning");
                return;
            }
            if (!int.TryParse(txtHeight.Text, out parsedValue))
            {
                MessageBox.Show("Height should be Numberical", "Value Type Warning");
                return;
            }
            if (!int.TryParse(txtWall1.Text, out parsedValue))
            {
                MessageBox.Show("Wall 1 should be Numberical", "Value Type Warning");
                return;
            }
            if (!int.TryParse(txtWall2.Text, out parsedValue))
            {
                MessageBox.Show("Wall 2 should be Numberical", "Value Type Warning");
                return;
            }
            if (!int.TryParse(txtWall3.Text, out parsedValue))
            {
                MessageBox.Show("Wall 3 should be Numberical", "Value Type Warning");
                return;
            }
            if (!int.TryParse(txtWall4.Text, out parsedValue))
            {
                MessageBox.Show("Wall 4 should be Numberical", "Value Type Warning");
                return;
            }
            if (!int.TryParse(txtISBN.Text, out parsedValue))
            {
                MessageBox.Show("ISBN should be Numberical", "Value Type Warning");
                return;
            }
            if (int.TryParse(txtName.Text, out parsedValue))
            {
                MessageBox.Show("Name should be Alphabetical", "Value Type Warning");
                return;
            }
        }
    }
}
