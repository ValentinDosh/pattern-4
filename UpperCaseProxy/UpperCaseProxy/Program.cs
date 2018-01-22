using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCaseProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProxyString str = new ProxyString("Harambaram");
            Console.WriteLine(str.CountLetter('a'));

            // теперь у нас есть копия строки в верхнем регистре
            Console.WriteLine(str.Value);
            
            Console.ReadLine();
        }
    }
}
