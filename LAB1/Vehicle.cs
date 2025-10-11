using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Car : BaseVehicle
    {
        public int Passengers { get; set; }
        public Car() { }
        public Car(string brand = "", string model = "", int year = 0, double price = 0.0, int passengers = 0)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Passengers = passengers;
        }


        public override string GetInfo()
        {
            return base.GetInfo() + $", Passengers: {Passengers}";
        }

        public override void PrintInfo()
        {
            Console.WriteLine(GetInfo());
        }

        public int GetPassengers()
        {
            return Passengers;
        }
        public void SetPassengers(int passengers)
        {
            Passengers = passengers;
        }
    }
    public class Bicycle : BaseVehicle
    {
        public int Gears { get; set; }//количество передач
        public Bicycle(string brand = "", string model = "", int year = 0, double price = 0.0, int gears = 0)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Gears = gears;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Gears: {Gears}";
        }

        public override void PrintInfo()
        {
            Console.WriteLine(GetInfo());
        }

        public int GetGears()
        {
            return Gears;
        }
        public void SetGears(int gears)
        {
            Gears = gears;
        }
    }
}



