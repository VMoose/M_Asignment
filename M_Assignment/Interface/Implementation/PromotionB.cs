namespace M_Assignment.Interface.Implementation {
    public class PromotionB : AbstractHandler {
        Product productB = null;

        public virtual object Handle(object request, float output =0){

            productB = (request as List<Product>).First(product => product.Sku == ProducType.B);
            if(productA.Quantity > 0){
                output += (productB.Quantity/2)*45 + (productB.Quantity % 2 * (float)ProductType.B);
            }
            return base.Handle(request, output);
        }
    }
}