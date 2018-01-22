using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeOrifmatic
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeArifmetic f = new FacadeArifmetic();

            int a = f.GetFactorial(10);
            double b = f.GetLog(300);
            int c = f.GetMulti(3,4);
            double d = f.GetSqrt(9);
            int e = f.GetSub(100, 99);
            int f2 = f.GetSum(2,2);
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", a, b, c, d, e, f2);
            Console.ReadLine();
        }
    }
}
