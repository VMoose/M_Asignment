using NUnit.Framework;

namespace Tests
{
    public class CalculatePriceTest
    {
        private Promotion promotionA;

        [SetUp]
        public void Setup()
        {
            promotionA = new Promotion();
            promotionA.SetNext(new promotionB ()).SetNext(new promotionCD ());
        }

        [Test]
        public void Should_calculateWithoutDiscount()
        {
            List<Products> products = new Products(){
                new Product 
                {
                    ]Sku = ProductType.A,
                    Quantity = 1
                },
                new Product 
                {
                    ]Sku = ProductType.B,
                    Quantity = 1
                },
                new Product 
                {
                    ]Sku = ProductType.C,
                    Quantity = 0
                },
                new Product 
                {
                    ]Sku = ProductType.D,
                    Quantity = 1
                }
            }

            var output = promotionA.Handle(products);

            Assert.AreEqual(95.0f, output);
        }


        [Test]
        public void Should_calculateWithDiscountA()
        {
            List<Products> products = new Products(){
                new Product 
                {
                    ]Sku = ProductType.A,
                    Quantity = 3
                },
                new Product 
                {
                    ]Sku = ProductType.B,
                    Quantity = 1
                },
                new Product 
                {
                    ]Sku = ProductType.C,
                    Quantity = 0
                },
                new Product 
                {
                    ]Sku = ProductType.D,
                    Quantity = 1
                }
            }

            var output = promotionA.Handle(products);

            Assert.AreEqual(175.0f, output);
        }

        [Test]
        public void Should_calculateWithDiscountB()
        {
            List<Products> products = new Products(){
                new Product 
                {
                    ]Sku = ProductType.A,
                    Quantity = 1
                },
                new Product 
                {
                    ]Sku = ProductType.B,
                    Quantity = 2
                },
                new Product 
                {
                    ]Sku = ProductType.C,
                    Quantity = 0
                },
                new Product 
                {
                    ]Sku = ProductType.D,
                    Quantity = 1
                }
            }

            var output = promotionA.Handle(products);

            Assert.AreEqual(110.0f, output);
        }

        [Test]
        public void Should_calculateWithDiscountCD()
        {
            List<Products> products = new Products(){
                new Product 
                {
                    ]Sku = ProductType.A,
                    Quantity = 1
                },
                new Product 
                {
                    ]Sku = ProductType.B,
                    Quantity = 1
                },
                new Product 
                {
                    ]Sku = ProductType.C,
                    Quantity = 1
                },
                new Product 
                {
                    ]Sku = ProductType.D,
                    Quantity = 1
                }
            }

            var output = promotionA.Handle(products);

            Assert.AreEqual(110.0f, output);
        }

        [Test]
        public void Should_calculateWithDiscountABCD()
        {
            List<Products> products = new Products(){
                new Product 
                {
                    ]Sku = ProductType.A,
                    Quantity = 3
                },
                new Product 
                {
                    ]Sku = ProductType.B,
                    Quantity = 2
                },
                new Product 
                {
                    ]Sku = ProductType.C,
                    Quantity = 1
                },
                new Product 
                {
                    ]Sku = ProductType.D,
                    Quantity = 1
                }
            }

            var output = promotionA.Handle(products);

            Assert.AreEqual(205.0f, output);
        }
    }
}