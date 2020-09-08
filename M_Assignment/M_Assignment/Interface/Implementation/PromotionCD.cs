using M_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace M_Assignment.Interface.Implementation {
    public class PromotionCD : AbstractHandler {
        Product productC = null;
        Product productD = null;
        public override object Handle(object request, float output = 0)
        {
            productC = (request as List<Product>).First(product => product.Sku == ProductType.C);
            productD = (request as List<Product>).First(product => product.Sku == ProductType.D);

            if (productC.Quantity > 0 && productD.Quantity > 0)
            {
                var difference = Math.Abs(productC.Quantity - productD.Quantity);
                if (productC.Quantity >= productD.Quantity)
                    output += productD.Quantity * 30.0F + difference * (float)ProductType.C;
                else
                    output += productC.Quantity * 30.0F + difference * (float)ProductType.D;
            }
            else if (productC.Quantity > 0)
            {
                output += productC.Quantity * (float)ProductType.C;
            }
            else if (productD.Quantity > 0)
            {
                output += productD.Quantity * (float)ProductType.D;
            }
            return base.Handle(request, output);
        }
    }
}