using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB1;
namespace TestProject1
{
    [TestClass]
    public sealed class Tests
    {

        [TestMethod]
        public void TestGetInfo_BaseVehicle()
        {
            var b = new BaseVehicle()
            {
                Brand = "Toyota",
                Model = "Camry",
                Year = 2010,
                Price = 1000000
            };

            var expected = "Brand: Toyota, Model: Camry, Year: 2010, Price: 1000000";
            Assert.AreEqual(expected, b.GetInfo());
        }


        [TestMethod]
        public void TestGetInfo_Car()
        {
            var car = new Car()
            {
                Brand = "Toyota",
                Model = "Camry",
                Year = 2010,
                Price = 1000000,
                Passengers = 2
            };

            var expected = "Brand: Toyota, Model: Camry, Year: 2010, Price: 1000000, Passengers: 2";
            Assert.AreEqual(expected, car.GetInfo());
        }


        [TestMethod]
        public void TestGetInfo_Bicycle()
        {
            var bicycle = new Bicycle()
            {
                Brand = "Toyota",
                Model = "Camry",
                Year = 2010,
                Price = 1000000,
                Gears = 2
            };

            var expected = "Brand: Toyota, Model: Camry, Year: 2010, Price: 1000000, Gears: 2";
            Assert.AreEqual(expected, bicycle.GetInfo());
        }

        [TestMethod]
        public void TestGetGears()
        {
            var bicycle = new Bicycle()
            {
                Gears = 2
            };

            int expected3 = 2;
            Assert.AreEqual(expected3, bicycle.GetGears());
        }



        [TestMethod]
        public void TestGetPassengers()
        {
            var car = new Car()
            {
                Passengers = 2
            };

            int expected3 = 2;
            Assert.AreEqual(expected3, car.GetPassengers());
        }


        [TestMethod]
        public void TestGetBrand()
        {
            var bs = new BaseVehicle()
            {
                Brand = "Toyota"
            };

            string expected3 = "Toyota";
            Assert.AreEqual(expected3, bs.GetBrand());
        }

        [TestMethod]
        public void TestGetModel()
        {
            var bs = new BaseVehicle()
            {
                Model = "Camry"
            };

            string expected3 = "Camry";
            Assert.AreEqual(expected3, bs.GetModel());
        }

        [TestMethod]
        public void TestGetYear()
        {
            var bs = new BaseVehicle()
            {
                Year = 1
            };

            int expected3 = 1;
            Assert.AreEqual(expected3, bs.GetYear());
        }

        [TestMethod]
        public void TestGetPrice()
        {
            var bs = new BaseVehicle()
            {
                Price = 1000000
            };

            double expected3 = 1000000;
            Assert.AreEqual(expected3, bs.GetPrice());
        }

        [TestMethod]
        public void TestSetBrand()
        {
            // arrange
            var vehicle = new BaseVehicle();
            var expected = "Toyota";

            // act
            vehicle.SetBrand(expected);

            // assert
            Assert.AreEqual(expected, vehicle.Brand);
        }

        [TestMethod]
        public void TestSetModel()
        {
            // arrange
            var vehicle = new BaseVehicle();
            var expected = "Camry";

            // act
            vehicle.SetModel(expected);

            // assert
            Assert.AreEqual(expected, vehicle.Model);
        }


        [TestMethod]
        public void TestSetYear()
        {
            // arrange
            var vehicle = new BaseVehicle();
            var expected = 2;

            // act
            vehicle.SetYear(expected);

            // assert
            Assert.AreEqual(expected, vehicle.Year);
        }


        [TestMethod]
        public void TestSetPrice()
        {
            // arrange
            var vehicle = new BaseVehicle();
            var expected = 1000000;

            // act
            vehicle.SetPrice(expected);

            // assert
            Assert.AreEqual(expected, vehicle.Price);
        }


        [TestMethod]
        public void TestSetGears()
        {
            // arrange
            var bike = new Bicycle();
            var expected = 2;

            // act
            bike.SetGears(expected);

            // assert
            Assert.AreEqual(expected, bike.Gears);
        }

        [TestMethod]
        public void TestSetPassengers()
        {
            // arrange
            var car = new Car();
            var expected = 2;

            // act
            car.SetPassengers(expected);

            // assert
            Assert.AreEqual(expected, car.Passengers);
        }

        [TestMethod]
        public void TestTryParseNumber()
        {
            // arrange
            string input = "123";

            // act
            bool success = Manager.TryParseNumber(input, out int result);

            // assert
            Assert.IsTrue(success);
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void TestPrintVehicles()
        {
            // arrange
            var vehicles = new List<BaseVehicle>
        {
        new BaseVehicle { Brand = "Toyota", Model = "Camry", Year = 2010, Price = 1000000 },
        new BaseVehicle { Brand = "BMW", Model = "X5", Year = 2020, Price = 3000000 }
        };

            var expected =
                "Brand: Toyota, Model: Camry, Year: 2010, Price: 1000000" + Environment.NewLine +
                "Brand: BMW, Model: X5, Year: 2020, Price: 3000000";

            var printer = new Manager();

            var standardOutput = Console.Out;

            try
            {
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // act
                    printer.printVehicles(vehicles);
                    string actual = sw.ToString().Trim();

                    // assert
                    Assert.AreEqual(expected, actual);
                }
            }
            finally
            {
                Console.SetOut(standardOutput); // восстановление обязательно
            }
        }

        [TestMethod]
        public void TestAddObject()
        {
            // arrange
            var vehicles = new List<BaseVehicle>();
            string fakeInput = string.Join(Environment.NewLine, new[]
            {
                "2", "Toyota", "Camry", "2010", "1000000", "4"
            });

            var standardOutput = Console.Out;
            var standardInput = Console.In;

            try
            {
                using (var input = new StringReader(fakeInput))
                using (var output = new StringWriter())
                {
                    Console.SetIn(input);
                    Console.SetOut(output);

                    var manager = new Manager();
                    manager.AddObject(vehicles);

                    Assert.AreEqual(1, vehicles.Count);
                    Assert.IsInstanceOfType(vehicles[0], typeof(Car));

                    var car = (Car)vehicles[0];
                    Assert.AreEqual("Toyota", car.Brand);
                    Assert.AreEqual("Camry", car.Model);
                    Assert.AreEqual(2010, car.Year);
                    Assert.AreEqual(1000000, car.Price);
                    Assert.AreEqual(4, car.Passengers);
                }
            }
            finally
            {
                Console.SetIn(standardInput);
                Console.SetOut(standardOutput);
            }
        }
    }

}