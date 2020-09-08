namespace M_Assignment.Interface.Implementation {
    public class PromotionA : AbstractHandler {
        Product productA = null;

        public virtual object Handle(object request, float output =0){

            productA = (request as List<Product>).First(product => product.Sku == ProducType.A);
            if(productA.Quantity > 0){
                output += (productA.Quantity/3)*130 + (productA.Quantity % 3 * (float)ProductType.A);
            }
            return base.Handle(request, output);
        }
    }
}