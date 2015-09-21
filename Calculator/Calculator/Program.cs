using System;

namespace Calulator
{
    class Program
    {
        delegate int MathOp(int _num1, int _num2);
        static void Main(string[] args)
        {
            MathOp mathOp;
            int num1, num2;

            start:

            Console.WriteLine("Skriv in två tal.");

            Console.Write("Tal1: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Tal2: ");
            num2 = Int32.Parse(Console.ReadLine());
            Convert.ToInt32("18");

            Console.Write("Välj operation 1=Addera, 2=Subtrahera, 3=Multiplicera, 4=Dividera, 5=xor: ");

            switch (Console.ReadLine())
            {
                case "1":
                    mathOp = Add;
                    break;
                case "+":
                    mathOp = Add;
                    break;
                case "2":
                    mathOp = Subtract;
                    break;
                case "-":
                    mathOp = Subtract;
                    break;
                case "3":
                    mathOp = Multiplicate;
                    break;
                case "*":
                    mathOp = Multiplicate;
                    break;
                case "4":
                    mathOp = Divide;
                    break;
                case "/":
                    mathOp = Divide;
                    break;
                case "5":
                    mathOp = Xor;
                    break;
                case "^":
                    mathOp = Xor;
                    break;
                default:
                    mathOp = Add;
                    break;
            }

            Console.WriteLine("Det blir: {0}", mathOp(num1, num2));
            Console.Write("Skriv \"igen\" för att starta om: ");
            if (Console.ReadLine() == "igen") goto start;

        }

        public static int Add(int _num1, int _num2)
        {
            return _num1 + _num2;
        }

        public static int Subtract(int _num1, int _num2)
        {
            return _num1 - _num2;
        }

        public static int Multiplicate(int _num1, int _num2)
        {
            return _num1 * _num2;
        }

        public static int Divide(int _num1, int _num2)
        {
            return _num1 / _num2;
        }

        public static int Xor(int _num1, int _num2)
        {
            return _num1 ^ _num2;
        }
    }
}
