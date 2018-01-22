using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDecorator
{
    class RussianProduct : DecoratorProduct
    {
        public RussianProduct(Product product) : base(product.Name + " из России", product)
        {

        }

        public override int GetPrice()
        {
            return _product.GetPrice() - 40;
        }
    }
    
    
}
