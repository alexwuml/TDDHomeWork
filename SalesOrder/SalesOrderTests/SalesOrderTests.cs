using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrder.Tests
{
    [TestClass()]
    public class SalesOrderTests
    {
        [TestMethod()]
        public void SalesOrderTest_GetTotalCostbyGroup()
        {
            //Arrange
            var target = new SalesOrder();
            List<SalesOrder> solist =
                new List<SalesOrder>
                {
                    new SalesOrder { Salesorderno="1",Cost=1,Revenue=11,Sellprice=21},
                    new SalesOrder { Salesorderno="2",Cost=2,Revenue=12,Sellprice=22},
                    new SalesOrder { Salesorderno="3",Cost=3,Revenue=13,Sellprice=23},
                    new SalesOrder { Salesorderno="4",Cost=4,Revenue=14,Sellprice=24},
                    new SalesOrder { Salesorderno="5",Cost=5,Revenue=15,Sellprice=25},
                    new SalesOrder { Salesorderno="6",Cost=6,Revenue=16,Sellprice=26},
                    new SalesOrder { Salesorderno="7",Cost=7,Revenue=17,Sellprice=27},
                    new SalesOrder { Salesorderno="8",Cost=8,Revenue=18,Sellprice=28},
                    new SalesOrder { Salesorderno="9",Cost=9,Revenue=19,Sellprice=29},
                    new SalesOrder { Salesorderno="10",Cost=10,Revenue=20,Sellprice=30},
                    new SalesOrder { Salesorderno="11",Cost=11,Revenue=21,Sellprice=31}
                };
            //Actual
            int[] actual = target.GetTotalCostbyGroup(3, solist);

            //Assert
            var expected = new int[] { 6, 15, 24, 21 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SalesOrderTest_GetTotalRevenuebyGroup()
        {
            //Arrange
            var target = new SalesOrder();
            List<SalesOrder> solist =
                new List<SalesOrder>
                {
                    new SalesOrder { Salesorderno="1",Cost=1,Revenue=11,Sellprice=21},
                    new SalesOrder { Salesorderno="2",Cost=2,Revenue=12,Sellprice=22},
                    new SalesOrder { Salesorderno="3",Cost=3,Revenue=13,Sellprice=23},
                    new SalesOrder { Salesorderno="4",Cost=4,Revenue=14,Sellprice=24},
                    new SalesOrder { Salesorderno="5",Cost=5,Revenue=15,Sellprice=25},
                    new SalesOrder { Salesorderno="6",Cost=6,Revenue=16,Sellprice=26},
                    new SalesOrder { Salesorderno="7",Cost=7,Revenue=17,Sellprice=27},
                    new SalesOrder { Salesorderno="8",Cost=8,Revenue=18,Sellprice=28},
                    new SalesOrder { Salesorderno="9",Cost=9,Revenue=19,Sellprice=29},
                    new SalesOrder { Salesorderno="10",Cost=10,Revenue=20,Sellprice=30},
                    new SalesOrder { Salesorderno="11",Cost=11,Revenue=21,Sellprice=31}
                };
            //Actual
            int[] actual = target.GetTotalRevenuebyGroup(4, solist);

            //Assert
            var expected = new int[] { 50, 66, 60 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}