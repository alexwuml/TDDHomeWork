using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TDDHW2
{
    [TestClass]
    public class ShhippingCartTests
    {
        [TestMethod]
        public void CalculateFee_1book_for_100()
        {
            //Arrange
            var target = new ShippingCart();
            List<Book> booklist =
                new List<Book>
            {
                new Book {Name ="",Qty=1,UnitPrice=100 }
            };

            //Actual
            double actual = target.CalculateFee(booklist);

            //Assert
            double expected = 100d;
            Assert.AreEqual(expected, actual);
        }
    }
}
