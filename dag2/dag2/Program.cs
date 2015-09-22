using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dag2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tSum\tDifference\tProduct\tQuotient\tModulus\tBitShift");
            for (int y = 1; y < 4; y++)
            {
                for (var x = 0; x < 10; x++)
                {

                    calc(x, y);

                }
            }
            Console.ReadLine();
        }
        public static void calc(int x, int y)
        {
            var sum = x + y;
            var difference = x - y;
            var product = x * y;
            var quotient = x / y;
            var mod = x % y;
            var bsl = x << y;
            Console.WriteLine("{0} {1}\t{2}\t{3}\t\t{4}\t{5}\t\t{6}\t{7}", x, y, sum, difference, product, quotient, mod,bsl);
        }
    }
}
