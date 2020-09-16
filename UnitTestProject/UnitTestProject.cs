using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductCartConsoleApp;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestProject
    {
        [TestMethod]
        public void GetTotalPriceTest()
        {
            //Arrange
            var cart = new ProductCartService();
            var ProductA = new GetTotalPrice {  };
            var ProductB = new GetTotalPrice {  };
            var ProductC = new GetTotalPrice {  };
            var ProductD = new GetTotalPrice {  };
            // Act
            cart.Add(ProductA);
            cart.Add(ProductB);
            cart.Add(ProductC);
            cart.Add(ProductD);
            // Assert
            Assert.AreEqual(2, cart.Items[0].Quantity);



        }
    }
}
