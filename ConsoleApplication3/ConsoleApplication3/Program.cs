using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marcus;

namespace ConsoleApplication3
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            ShowText();
            var number1 = MConsole.ReadDecimal();
            var number2 = MConsole.ReadDecimal();
            Console.WriteLine(calc.Add(number1,number2));
            Console.ReadLine();
        }
        static void ShowText()
        {
            Console.WriteLine("Enter two Numbers.");
        }
    }

}
