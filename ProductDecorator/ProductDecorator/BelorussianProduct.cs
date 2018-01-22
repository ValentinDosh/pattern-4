using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDecorator
{
    class BelorussianProduct : DecoratorProduct
    {
        public BelorussianProduct(Product product) : base(product.Name + " из Беларуси", product)
        {

        }

        public override int GetPrice()
        {
            return _product.GetPrice() + 20;
        }
    }
}
