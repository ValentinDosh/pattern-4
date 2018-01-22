using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDecorator
{
    class Bed : Product
    {
        public Bed() : base("Кровать", "#125")
        {
        }

        public override int GetPrice()
        {
            return 780;
        }
    }
}
