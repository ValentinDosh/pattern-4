using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            ICountLetter str = new String("Hello");
            Console.WriteLine(str.CountLetter('l'));

            str.Value = "Harambara";
            Console.WriteLine(str.CountLetter('a'));
        }
    }
}
