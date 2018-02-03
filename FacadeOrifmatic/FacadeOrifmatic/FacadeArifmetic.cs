using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeOrifmatic
{
    class FacadeArifmetic
    {
        public double GetLog(double number)
        {
            return Logarifm.ResultLogarifm(number);
        }

        public double GetSqrt(double number)
        {
            return Sqrt.ResultSqrt(number);
        }

        public int GetFactorial(int number)
        {
            return Factorial.ResultFactorial(number);
        }

        public int GetSub(int x, int y)
        {
            return Substraction.ResultSub(x, y);
        }

        public int GetSum(int x, int y)
        {
            return Sum.ResultSum(x, y);
        }

        public int GetMulti(int x, int y)
        {
            return Multiplication.ResultMulti(x, y);
        }
    }
}
