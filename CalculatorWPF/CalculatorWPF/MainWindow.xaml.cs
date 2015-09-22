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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Calculator calc = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
            textBox.Focus();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if(Decimal.TryParse(textBox.Text, out calc.number1))
            {
                textBox.Text = calc.number1.ToString();
                if (textBox.Text.Length != 0)
                {
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                }
            }
            else
            {
                if(textBox.Text[textBox.Text.Length-1]==',' && textBox.Text.Length!=0)
                {

                }
                else if (textBox.Text.Length != 0)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                }
            }

        }
    }
    public class Calculator
    {
        public Decimal number1 = 0;


    }
}
