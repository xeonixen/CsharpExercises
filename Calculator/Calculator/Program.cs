using System;

namespace Calulator
{
    class Program
    {
        delegate double MathOp(double _num1, double _num2);
        static void Main(string[] args)
        {
            MathOp mathOp;
            double num1, num2;
            string input;
            while (true)
            {

                Console.WriteLine("Skriv in två tal. A för att avbryta.");

            choose1:
                Console.Write("Tal 1: ");
                input = Console.ReadLine();
                input = input.ToLower();
                if (!Double.TryParse(input, out num1))
                {
                    if (String.Compare(input, "a") == 0) break;
                    else
                    {
                        Console.WriteLine("Felaktig inmatning, försök igen.");
                        goto choose1;
                    }
                }

            choose2:
                Console.Write("Tal 2: ");
                input = Console.ReadLine();
                if (!Double.TryParse(input, out num2))
                {
                    if (String.Compare(input, "a") == 0) break;
                    else
                    {
                        Console.WriteLine("Felaktig inmatning, försök igen.");
                        goto choose2;
                    }
                }

                Console.Write("\t1=Addera\n \t2=Subtrahera\n \t3=Multiplicera\n \t4=Dividera\n \t5=xor\n");
                goto choose3;
            avbryt:
                break;
            choose3:
                Console.Write("Välj: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        mathOp = Addera;
                        break;
                    case "+":
                        mathOp = Addera;
                        break;
                    case "2":
                        mathOp = Subtrahera;
                        break;
                    case "-":
                        mathOp = Subtrahera;
                        break;
                    case "3":
                        mathOp = Multiplicera;
                        break;
                    case "*":
                        mathOp = Multiplicera;
                        break;
                    case "4":
                        mathOp = Dividera;
                        break;
                    case "/":
                        mathOp = Dividera;
                        break;
                    case "a":
                        goto avbryt;
                    case "A":
                        goto avbryt;
                    default:
                        Console.WriteLine("Felaktig inmatning! Försök igen.");
                        goto choose3;
                       // break;
                }

                Console.WriteLine("Det blir: {0}", mathOp(num1, num2));
            }

        }

        public static double Addera(double _num1, double _num2)
        {
            return _num1 + _num2;
        }

        public static double Subtrahera(double _num1, double _num2)
        {
            return _num1 - _num2;
        }

        public static double Multiplicera(double _num1, double _num2)
        {
            return _num1 * _num2;
        }

        public static double Dividera(double _num1, double _num2)
        {
            return _num1 / _num2;
        }
    }
}
