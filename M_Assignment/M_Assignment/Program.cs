using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M_Assignment.Models;
using M_Assignment.Interface.Implementation;
using System.Threading.Tasks;

namespace M_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Product> products = new List<Product>();

           foreach(ProductType productT in Enum.GetValues(typeof(ProductType))){
               Console.WriteLine("Please enter the quantity for product type " + productT);
               bool isInvalid = true;
               int quantity =0;
               while(isInvalid){
                   string input = Console.ReadLine();
                   if(int.TryParse(input, out quantity)){
                       isInvalid = false;
                   }
                    else
                        Console.WriteLine("Not and integer, please try again.");
               }

               Product product = new Product();
               product.Sku = productT;
               product.Quantity = quantity;

               products.Add(product);
           }

           PromotionA promotionA = new PromotionA();
           promotionA.SetNext(new PromotionB()).SetNext(new PromotionCD());

           Console.WriteLine("Total Price of the cart: ", promotionA.Handle(products));
           Console.ReadKey();
        }
    }
}
