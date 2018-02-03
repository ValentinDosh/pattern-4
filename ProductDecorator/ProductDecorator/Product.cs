using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDecorator
{
    abstract class Product
    {
        public Product(string name, string articul)
        {
            Name = name;
            Articul = articul;
        }

        public string Name { get; protected set; }
        public string Articul { get; protected set; }
        public abstract int GetPrice();
    }
}
