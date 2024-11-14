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

namespace Week1_Controls
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Compute_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text); 
            int num2 = int.Parse(TextBox2.Text);
            int result = num1 * num2; 
             
            Result.Text=result.ToString(); 

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox2.Text = Result.Text = " "; 
        }
    }
}
