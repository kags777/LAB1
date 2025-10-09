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
        public Car(string brand = "", string model = "", int year = 0, double price = 0.0, int passengers = 0)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Passengers = passengers;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($" Passengers: {Passengers}");
            Console.WriteLine("");
           
        }
        public void GetPassengers()
        {
            Console.WriteLine($"{Passengers}");
        }
        public void SetPassengers(int passengers)
        {
            Passengers = passengers;
        }
    }
    class Bicycle : BaseVehicle
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

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write($" Gears: {Gears}");
            Console.WriteLine("");
           
        }

        public void GetGears()
        {
            Console.WriteLine($"{Gears}");
        }
        public void setGears(int gears)
        {
            Gears = gears;
        }
    }
}



