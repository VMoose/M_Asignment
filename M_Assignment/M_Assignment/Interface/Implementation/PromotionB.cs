using M_Assignment.Models;
using System.Collections.Generic;
using System.Linq;

namespace M_Assignment.Interface.Implementation {
    public class PromotionB : AbstractHandler {
        Product productB = null;
        public override object Handle(object request, float output = 0)
        {
            productB = (request as List<Product>).First(product => product.Sku == ProductType.B);
            if (productB.Quantity > 0)
            {
                output += (productB.Quantity / 2) * 45 + (productB.Quantity % 2 * (float)ProductType.B);
            }
            return base.Handle(request, output);
        }
    }
}