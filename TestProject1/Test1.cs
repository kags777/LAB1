using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB1;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestPrintBase()
        {
            // arrange
            var expected = "Brand: Toyota, Model: Camry, Year: 2010, Price: 1000000";

            var b = new BaseVehicle()
            {
                Brand = "Toyota",
                Model = "Camry",
                Year = 2010,
                Price = 1000000
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); // перенаправляем вывод консоли в StringWriter

                // act
                b.PrintInfo();
                string actual = sw.ToString(); // получаем всё, что вывелось в консоль

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void TestPrintCar()
        {
            // arrange
            var expected = "Brand: Toyota, Model: Camry, Year: 2010, Price: 1000000 Passengers: 2";

            var b = new Car()
            {
                Brand = "Toyota",
                Model = "Camry",
                Year = 2010,
                Price = 1000000,
                Passengers = 2
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); // перенаправляем вывод консоли в StringWriter

                // act
                b.PrintInfo();
                string actual = sw.ToString(); // получаем всё, что вывелось в консоль

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

    }
}
