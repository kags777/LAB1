using LAB1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Manager
    {
        int Year,Price;
        int a = 0;
        public void addObject(std::list<std::unique_ptr<BaseVehicle>>& vehicles)
        {
            Console.WriteLine("Choose type of vehicle to add:\n");
            Console.WriteLine("1. BaseVehicle\n");
            Console.WriteLine("2. Car\n");
            Console.WriteLine("3. Bicycle\n");
            string choice = Console.ReadLine();

            Console.WriteLine("Enter brand: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter model: ");
            string model = Console.ReadLine();
         do
            { 
            Console.WriteLine("Enter year: ");
            string year = Console.ReadLine();

            if (int.TryParse(year, out Year))
            {
                a = 1;
            }

            else
            {
                Console.WriteLine("Ошибка: это не число!");
            }
        } while (a != 1);

            do { 
            Console.WriteLine("Enter price: ");
            string price = Console.ReadLine();
            if (int.TryParse(price, out Price))
            {
                a = 1;
            }

            else
            {
                Console.WriteLine("Ошибка: это не число!");
            }
        } while (a != 1);




            switch (choice)
            {
                case 1:
                    vehicles.push_back(std::make_unique<BaseVehicle>(brand, model, Year, Price));
                    break;
                case 2:
                    {

                        int Passengers;
                        do { 
                        Console.WriteLine( "Enter number of passengers: ");
                        string passengers = Console.ReadLine();
                        
                        if (int.TryParse(passengers, out Passengers))
                        {
                            a = 1;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка: это не число!");
                        }
                    } while (a != 1);


                    vehicles.push_back(std::make_unique<Car>(brand, model, year, price, passengers));
                        break;
                    }
                case 3:
                    {
                        int Gears;
                        Console.WriteLine( "Enter number of gears: ");
                        string gears = Console.ReadLine();
                        vehicles.push_back(std::make_unique<Bicycle>(brand, model, year, price, gears));
                        break;
                    }
                default:
                    Console.WriteLine("Invalid choice.\n");
                    break;
            }
        }

        void printVehicles(const std::list<std::unique_ptr<BaseVehicle>>& vehicles)
{
    for (auto&vehicle : vehicles) {
        vehicle->printInfo();
    }
}


std::list<std::unique_ptr<BaseVehicle>> vehicles;
    }
}


 int a = 0;//вспомогательная переменная
int number; // еще одна вспомогательная переменная

do
{
    do
    {
        Console.WriteLine("Select the desired operation");
        Console.WriteLine("\nMenu:\n");
        Console.WriteLine("1. Add vehicle\n");
        Console.WriteLine("2. Print vehicles\n");
        Console.WriteLine("3. Exit\n");
        string choice = Console.ReadLine();

        if (int.TryParse(choice, out number))
        {
            a = 1;
        }

        else
        {
            Console.WriteLine("Ошибка: это не число!");
        }
    } while (a != 1);


    switch (number)
    {
        case 1:
            addObject(vehicles);
            break;
        case 2:
            printVehicles(vehicles);
            break;
        case 3:
            return 0;
        default:
            Console.WriteLine("Invalid choice.\n");
            break;
    }

} while (true);