using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hafta8();
            hafta9();

        }

        private static void hafta9()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(" Brand : {0}\n Car : {1}\n Color : {2}\n FuelType : {3}\n Daily Price : {4}",
                    car.BrandName, car.Name, car.ColorName, car.FuelType, car.DailyPrice);
                Console.WriteLine("------------------------------");
            }
        }

        private static void hafta8()
        {
            Car car1 = new Car { Name = "411", BrandId = 3, ColorId = 1, FuelTypeId = 2, DailyPrice = 15, ModelYear = 2015, Description = "otomatik" };

            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(car1);
            //carManager.Delete(new Car { Id = 5});

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine();

            foreach (var car in carManager.GetByFuelType(4))
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine();

            foreach (var car in carManager.GetByDailyPrice(500, 1000))
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine();
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }
            Console.WriteLine();
        }
    }
}
