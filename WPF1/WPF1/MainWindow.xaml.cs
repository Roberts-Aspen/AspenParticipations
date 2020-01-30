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
//Aspen Roberts
namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtName.Text = "";
            txtAddress.Text = string.Empty;
            txtZip.Text = string.Empty;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string Name, Address, ZipCode;

            Name = txtName.Text;
            Address = txtAddress.Text;
            ZipCode = txtZip.Text;

            //EntryForm entry = new EntryForm(Name, Address, Convert.ToInt32(ZipCode));

            listBox.Items.Add($"{Name} {Address} {ZipCode}");

          
        }
    }
}
