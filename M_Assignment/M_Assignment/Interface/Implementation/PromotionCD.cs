namespace M_Assignment.Interface.Implementation {
    public class PromotionCD : AbstractHandler {
        Product productC = null;
        Product productD = null;

        public virtual object Handle(object request, float output =0){

            productC = (request as List<Product>).First(product => product.Sku == ProducType.C);
            productD = (request as List<Product>).First(product => product.Sku == ProducType.D);

            if(productC.Quantity > 0 && productD.Quantity > 0){
                var difference = Math.Abs(productC.Quantity - productD.Quantity);
                if(productC.Quantity >= productD.Quantity)
                {
                    output += productD.Quantity*30.0F + difference * (float)ProducType.C;
                }
                else
                    output += productC.Quantity*30.0F + difference * (float)ProducType.D;
            }

            else if(productC.Quantity > 0){
                output += productC.Quantity * (float)ProducType.C;
            }
            else if(productD.Quantity > 0){
                output += productD.Quantity * (float)ProducType.D;
            }
            return base.Handle(request, output);
        }
    }
}