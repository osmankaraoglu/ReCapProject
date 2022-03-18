using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car { Name = "411", BrandId = 3, ColorId = 1, FuelTypeId = 2, DailyPrice = 15, ModelYear = 2015, Description = "otomatik" };

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
