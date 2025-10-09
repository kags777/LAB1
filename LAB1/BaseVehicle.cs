using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class BaseVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        // Конструктор с параметрами и значениями по умолчанию
        public BaseVehicle(string brand = "", string model = "", int year = 0, double price = 0.0)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }

        // Виртуальная функция для вывода (печати) сведений об объекте класса
        public virtual void PrintInfo()
        {
            Console.Write($"Brand: {Brand}, Model: {Model}, Year: {Year}, Price: {Price}");
        }

        // Функции для получения значений характеристик объекта
        public void GetBrand()
        {
            Console.WriteLine($"{Brand}");
        }
        public void GetModel()
        {
            Console.WriteLine($"{Model}");
        }

        public void GetYear()
        {
            Console.WriteLine($"{Year}");
        }
        public void GetPrice()
        {
            Console.WriteLine($"{Price}");
        }

        // Функции для изменения значений характеристик объекта
        public void SetBrand(string brand)
        {
            Brand = brand;
        }

        public void SetModel(string model)
        {
            Model = model;
        }

        public void SetYear(int year) 
        {
            Year = year;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
    };
}
