using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcus
{
    public class Calculator
    {
        public Decimal number1=0, number2=0;
        public Decimal Add(Decimal a, Decimal b)
        {
            return a + b;
        }
        public Decimal Subtract(Decimal a, Decimal b)
        {
            return a - b;
        }
        public Decimal Divide(Decimal a, Decimal b)
        {
            if (b != 0)
                return a / b;
            else return 0;
        }
        public Decimal Multiply(Decimal a, Decimal b)
        {
            return a * b;
        }
    }
}
