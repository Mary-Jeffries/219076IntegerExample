/*Ian McTavish
 * Feb 11, 2019
 * Example code for using integers
 */
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

namespace integerExample
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

        /// <summary>
        /// will output 4 - requires a TextBlock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            int x;//declare a variable
            x = 3;//assign a value to the variable
            x = x + 1;//Add one to the variable
            //The next line requires a TextBlock with an x:Name attribute of txtOutput
            txtOutput.Text = x.ToString(); //output the variable
        }

        /// <summary>
        /// Will output twice the value the user enters.
        /// Requires TextBox and TextBlock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExample2_Click(object sender, RoutedEventArgs e)
        {
            int x;//declare a variable
            int.TryParse(txtInput.Text, out x);//assign a value from user input
            x = x * 2;//multiply the variable by 2
            txtOutput.Text = x.ToString();//output the variable
        }
    }
}
