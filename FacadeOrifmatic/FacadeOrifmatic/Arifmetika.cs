using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeOrifmatic
{
    class Factorial
    {
        public static int ResultFactorial(int number)
        {
            if (number > 12)
                return 0;

            if (number == 1)
                return 1;
            else
            {
                return number * ResultFactorial(number - 1);
            }
        }
    }

    class Logarifm
    {
        public static double ResultLogarifm(double number)
        {
            return Math.Log10(number);
        }
    }

    class Sqrt
    {
        public static double ResultSqrt(double number)
        {
            return Math.Sqrt(number);
        }
    }

    class Sum
    {
        public static int ResultSum(int x, int y)
        {
            return x + y;
        }
    }

    class Substraction
    {
        public static int ResultSub(int x, int y)
        {
            return x - y;
        }
    }

    class Multiplication
    {
        public static int ResultMulti(int x, int y)
        {
            return x * y;
        }
    }
}
