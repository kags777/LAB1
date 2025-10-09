using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Reflection;
using LAB1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrintBase()
        {
            //arrange
            string Brand = "Toyota";
            string Model = "Camry";
            int Year = 2010;
            int Price = 1000000;
            string expected = "Brand: Toyota, Model: Camry, Year: 2010, Price: 1000000";

            //act
            BaseVehicle b = new BaseVehicle()
            {

                Brand = Brand,
                Model = Model,
                Year = Year,
                Price = Price

            };

            string actual = b.PrintInfo();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
