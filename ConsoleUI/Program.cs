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
            //hafta9();
            //hafta10();

        }

        private static void hafta10()
        {
            //Rental rental1 = new Rental { CarId = 5, CustomerId = 2, RentDate = new DateTime(2022, 04, 07), ReturnDate = new DateTime(2022, 05, 01) };
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(rental1);
            //Console.WriteLine();
            //rentalManager.Delete(new Car { Id = 5});

            foreach (var rent in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(" UserName : {0}\n CarName : {1}\n CustomerName : {2}\n RentDate : {3}\n ReturnDate : {4}"
                    , rent.UserName, rent.CarName, rent.CustomerName, rent.RentDate, rent.ReturnDate);
                Console.WriteLine("------------------------------");
            }
        }

        private static void hafta9()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
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
            carManager.Add(car1);
            carManager.Delete(new Car { Id = 5});

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine();

            foreach (var car in carManager.GetByFuelType(4).Data)
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine();

            foreach (var car in carManager.GetByDailyPrice(500, 1000).Data)
            {
                Console.WriteLine(car.Name);
            }
            Console.WriteLine();
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Id);
            }
            Console.WriteLine();
        }
    }
}
