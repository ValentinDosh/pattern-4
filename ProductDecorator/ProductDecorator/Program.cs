using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Product tv1 = new TV();
            tv1 = new BelorussianProduct(tv1);
            Console.WriteLine("{0}, стоимость - {1}, артикул - {2}", tv1.Name, tv1.GetPrice(), tv1.Articul);

             Product tv2 = new TV();
            tv2 = new RussianProduct(tv2);
            Console.WriteLine("{0}, стоимость - {1}, артикул - {2}", tv2.Name, tv2.GetPrice(), tv2.Articul);

            Console.ReadLine();
        }
    }
}
