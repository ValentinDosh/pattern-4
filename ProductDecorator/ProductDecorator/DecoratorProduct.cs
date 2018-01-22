using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDecorator
{
    abstract class DecoratorProduct : Product
    {
        protected Product _product;
        public DecoratorProduct(string name, Product product) : base(name, product.Articul)
        {
            _product = product;
        }
    }
}
