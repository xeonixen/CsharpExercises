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
using Marcus;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate Decimal MathOperation(Decimal num1, Decimal num2);
        public MathOperation mathOp;
        public Calculator calc = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
            textBox.Focus();
        }

        private void CheckText()
        {
            Decimal number;
            while(!Decimal.TryParse(textBox.Text,out number) && textBox.Text.Length!=0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                
            }
            textBox.Text = number.ToString();
        }
        private Decimal GetNumber()
        {
            Decimal number;
            if (Decimal.TryParse(textBox.Text, out number))
                return number;
            else return 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case "button0":
                    textBox.Text += "0";
                    CheckText();
                    break;
                case "button1":
                    textBox.Text += "1";
                    CheckText();
                    break;
                case "button2":
                    textBox.Text += "2";
                    CheckText();
                    break;
                case "button3":
                    textBox.Text += "3";
                    CheckText();
                    break;
                case "button4":
                    textBox.Text += "4";
                    CheckText();
                    break;
                case "button5":
                    textBox.Text += "5";
                    CheckText();
                    break;
                case "button6":
                    textBox.Text += "6";
                    CheckText();
                    break;
                case "button7":
                    textBox.Text += "7";
                    break;
                case "button8":
                    textBox.Text += "8";
                    CheckText();
                    break;
                case "button9":
                    textBox.Text += "9";
                    CheckText();
                    break;
                case "buttonComma":
                    textBox.Text += ",";
                    break;
                case "buttonAdd":
                    calc.number1 = GetNumber();
                    textBox.Text = "0";
                    mathOp = calc.Add;
                    break;
                case "buttonSubtract":
                    calc.number1 = GetNumber();
                    textBox.Text = "0";
                    mathOp = calc.Subtract;
                    break;
                case "buttonDivide":
                    calc.number1 = GetNumber();
                    textBox.Text = "0";
                    mathOp = calc.Divide;
                    break;
                case "buttonMultiply":
                    calc.number1 = GetNumber();
                    textBox.Text = "0";
                    mathOp = calc.Multiply;
                    break;
                case "buttonSign":
                    textBox.Text = (-GetNumber()).ToString();
                    break;

                case "buttonEqual":
                    if (mathOp != null)
                    {
                        calc.number2 = GetNumber();
                        textBox.Text= mathOp(calc.number1, calc.number2).ToString();
                    }

                    break;
                case "buttonDelete":
                    //textBox.Text += ",";
                    if (textBox.Text.Length > 0) textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    if (textBox.Text.Length == 0) textBox.Text = "0";
                    break;
            }
        }
    }

}
