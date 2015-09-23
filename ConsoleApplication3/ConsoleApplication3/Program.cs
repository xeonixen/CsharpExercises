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
            calc.number1 = MConsole.ReadDecimal();
            calc.number2 = MConsole.ReadDecimal();
            Console.WriteLine(calc.Add());
            Console.ReadLine();
        }
        static void ShowText()
        {
            Console.WriteLine("Enter two Numbers.");
        }
    }

}
