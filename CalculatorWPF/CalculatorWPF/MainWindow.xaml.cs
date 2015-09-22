using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Marcus;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate Decimal MathOperation();
        public MathOperation mathOp;
        public Calculator calc = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
            
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
                case "buttonSqrt":
                    calc.number1 = GetNumber();
                    mathOp = calc.Sqrt;
                    textBox.Text = mathOp().ToString();
                    break;
                case "buttonSign":
                    textBox.Text = (-GetNumber()).ToString();
                    break;
                case "buttonSquare":
                    calc.number1 = GetNumber();
                    mathOp = calc.Square;
                    textBox.Text = mathOp().ToString();
                    break;
                case "buttonEqual":
                    if (mathOp != null)
                    {
                        calc.number2 = GetNumber();
                        textBox.Text= mathOp().ToString();
                    }
                    break;
                case "buttonDelete":
                    if (textBox.Text.Length > 0) textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    if (textBox.Text.Length == 0) textBox.Text = "0";
                    break;
            }
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            
            KeyValueSerializer keyValue = new KeyValueSerializer();
            string sKey = keyValue.ConvertToString(e.Key, null);
            Int32 input;
            bool parseResult=Int32.TryParse(sKey,out input);
            if(parseResult && (input<=9 && input>=0))
            {
                textBox.Text += sKey;
                CheckText();
            }

            switch (e.Key)
            {
                case Key.Escape:
                    Close();
                    break;
                case Key.OemPlus:
                    calc.number1 = GetNumber();
                    mathOp = calc.Add;
                    textBox.Text = "0";
                    break;
                case Key.OemMinus:
                    calc.number1 = GetNumber();
                    mathOp = calc.Subtract;
                    textBox.Text = "0";
                    break;
                case Key.OemQuestion:
                    calc.number1 = GetNumber();
                    mathOp = calc.Multiply;
                    textBox.Text = "0";
                    break;
                case Key.D7:
                    if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                    {
                        calc.number1 = GetNumber();
                        mathOp = calc.Divide;
                        textBox.Text = "0";
                    }
                    break;

                case Key.Enter:
                    if (mathOp != null)
                    {
                        calc.number2 = GetNumber();
                        textBox.Text = mathOp().ToString();
                    }
                    break;
            }
  
        }
    }

}
