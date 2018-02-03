using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDecorator
{
    class TV : Product
    {
        public TV() : base("Телевизор", "#123")
        {
        }

        public override int GetPrice()
        {
            return 980;
        }
    }
}
