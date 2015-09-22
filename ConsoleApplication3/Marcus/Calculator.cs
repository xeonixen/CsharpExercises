using System;

namespace Marcus
{
    public class Calculator
    {
        public Decimal number1=0, number2=0;
        public Decimal Add()
        {
            return number1 + number2;
        }
        public Decimal Subtract()
        {
            return number1 - number2;
        }
        public Decimal Divide()
        {
            if (number2 != 0)
                return number1 / number2;
            else return 0;
        }
        public Decimal Multiply()
        {
            try
            {
                return number1 * number2;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public Decimal Sqrt()
        {
            return Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(number1)));
        }
        public Decimal Square()
        {
            try
            {
                return number1 * number1;
            }
            catch (Exception)
            {

                return 0;
            }
            
        }
    }
}
