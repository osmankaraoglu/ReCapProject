using Business.Concrate;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car1 = new Car();
            car1.Id = 9;
            car1.BrandId = 6;
            car1.ColorId = 3;
            car1.FuelTypeId = 1;
            car1.Name = "Porche Cayenne";
            car1.ModelYear = 2016;
            car1.DailyPrice = 440;
            car1.Description = "Otomatik Vites";

            Car car2 = new Car();
            car2.Id = 3;
            car2.BrandId = 3;
            car2.ColorId = 2;
            car2.FuelTypeId = 1;
            car2.Name = "BMW M5";
            car2.ModelYear = 2016;
            car2.DailyPrice = 500;
            car2.Description = "Manuel Vites";

            

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine();

            Console.WriteLine(carManager.GetById(2).Name);
            Console.WriteLine();

            carManager.Add(car1);
            carManager.Update(car2);
            carManager.Delete(new Car { Id = 1 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine();

        }
    }
}
