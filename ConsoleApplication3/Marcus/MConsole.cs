using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcus
{
    public class MConsole
    {
        public static Decimal ReadDecimal()
        {
            string input;
            Decimal number;
            while (true)
            {
                input = Console.ReadLine();
                if (!Decimal.TryParse(input, out number))
                {
                    Console.WriteLine("Wrong Input! Try again.");
                }
                else break;
            }
            
            return number;
        }
    }
}
