using LAB1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Manager
    {
        int Year, Price, a = 0, Choice;
        bool invalidArg;

        public void AddObject(List<BaseVehicle> vehicles)
        {

            do
            {
                invalidArg = false;
                Console.WriteLine("Choose type of vehicle to add:\n");
                Console.WriteLine("1. BaseVehicle\n");
                Console.WriteLine("2. Car\n");
                Console.WriteLine("3. Bicycle\n");

                string choice = Console.ReadLine();
                invalidArg = TryParseNumber(choice, out Choice);
            } while (invalidArg != true);

            Console.WriteLine("Enter brand: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter model: ");
            string model = Console.ReadLine();

            do
            {
                invalidArg = false;
                Console.WriteLine("Enter year: ");
                string year = Console.ReadLine();
                invalidArg = TryParseNumber(year, out Year);
            } while (invalidArg != true);

            do
            {
                invalidArg = false;
                Console.WriteLine("Enter price: ");
                string price = Console.ReadLine();
                invalidArg = TryParseNumber(price, out Price);
            } while (invalidArg != true);

            switch (Choice)
            {
                case 1:
                    vehicles.Add(new BaseVehicle(brand, model, Year, Price));
                    break;

                case 2:
                    {
                        int Passengers;
                        do
                        {
                            invalidArg = false;
                            Console.WriteLine("Enter number of passengers: ");
                            string passengers = Console.ReadLine();

                            invalidArg = TryParseNumber(passengers, out Passengers);
                        } while (invalidArg != true);

                        vehicles.Add(new Car(brand, model, Year, Price, Passengers));
                        break;
                    }

                case 3:
                    {
                        int Gears;
                        do
                        {
                            invalidArg = false;
                            Console.WriteLine("Enter number of gears: ");
                            string gears = Console.ReadLine();
                            invalidArg = TryParseNumber(gears, out Gears);
                        } while (invalidArg != true);
                        vehicles.Add(new Bicycle(brand, model, Year, Price, Gears));
                        break;
                    }
                default:
                    Console.WriteLine("Invalid choice.\n");
                    break;
            }
        }
        public void printVehicles(List<BaseVehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.PrintInfo();
            }

        }
        public static bool TryParseNumber(string input, out int result)
        {
            if (int.TryParse(input, out result))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Ошибка: это не число!");
                return false;
            }
        }

    }
}