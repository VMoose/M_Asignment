using NUnit.Framework;
using System.Collections.Generic;
using M_Assignment.Models;
using M_Assignment.Interface.Implementation;

namespace Tests
{
    public class CalculatePriceTest
    {
        private PromotionA promotionA;

        [SetUp]
        public void Setup()
        {
            promotionA = new PromotionA();
            promotionA.SetNext(new PromotionB ()).SetNext(new PromotionCD ());
        }

        [Test]
        public void Should_calculateWithoutDiscount()
        {
            List<Product> products = new List<Product>() {
                new Product
                {
                    Sku = ProductType.A,
                    Quantity =1
                },
                new Product
                {
                    Sku = ProductType.B,
                    Quantity =1
                },
                new Product
                {
                    Sku = ProductType.C,
                    Quantity =0
                },
                new Product
                {
                    Sku = ProductType.D,
                    Quantity =1
                }

            };

            var output = promotionA.Handle(products);

            Assert.AreEqual(95.0f, output);
        }


        [Test]
        public void Should_calculateWithDiscountA()
        {
            List<Product> products = new List<Product>() {
                new Product
                {
                    Sku = ProductType.A,
                    Quantity =3
                },
                new Product
                {
                    Sku = ProductType.B,
                    Quantity =1
                },
                new Product
                {
                    Sku = ProductType.C,
                    Quantity =0
                },
                new Product
                {
                    Sku = ProductType.D,
                    Quantity =1
                }

            };

            var output = promotionA.Handle(products);

            Assert.AreEqual(175.0f, output);
        }

        [Test]
        public void Should_calculateWithDiscountB()
        {
            List<Product> products = new List<Product>() {
                new Product
                {
                    Sku = ProductType.A,
                    Quantity =1
                },
                new Product
                {
                    Sku = ProductType.B,
                    Quantity =2
                },
                new Product
                {
                    Sku = ProductType.C,
                    Quantity =0
                },
                new Product
                {
                    Sku = ProductType.D,
                    Quantity =1
                }

            };

            var output = promotionA.Handle(products);

            Assert.AreEqual(110.0f, output);
        }

        [Test]
        public void Should_calculateWithDiscountCD()
        {
            List<Product> products = new List<Product>() {
                new Product
                {
                    Sku = ProductType.A,
                    Quantity =1
                },
                new Product
                {
                    Sku = ProductType.B,
                    Quantity =1
                },
                new Product
                {
                    Sku = ProductType.C,
                    Quantity =1
                },
                new Product
                {
                    Sku = ProductType.D,
                    Quantity =1
                }

            };

            var output = promotionA.Handle(products);

            Assert.AreEqual(110.0f, output);
        }

        [Test]
        public void Should_calculateWithDiscountABCD()
        {
            List<Product> products = new List<Product>() {
                new Product
                {
                    Sku = ProductType.A,
                    Quantity =3
                },
                new Product
                {
                    Sku = ProductType.B,
                    Quantity =2
                },
                new Product
                {
                    Sku = ProductType.C,
                    Quantity =1
                },
                new Product
                {
                    Sku = ProductType.D,
                    Quantity =1
                }

            };

            var output = promotionA.Handle(products);

            Assert.AreEqual(205.0f, output);
        }
    }
}