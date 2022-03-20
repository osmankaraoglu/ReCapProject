using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
            new Car { Id = 1, BrandId = 1, ColorId = 2, FuelTypeId = 1, Name = "Ford Focus",
                ModelYear = 2018, DailyPrice= 350, Description = "Otomatik Vites" },
            new Car { Id = 2, BrandId = 2, ColorId = 3, FuelTypeId = 2, Name = "Fiat Linea",
                ModelYear = 2015, DailyPrice= 250, Description = "Manuel Vites" },
            new Car { Id = 3, BrandId = 3, ColorId = 4, FuelTypeId = 1, Name = "BMW M3",
                ModelYear = 2012, DailyPrice= 320, Description = "Manuel Vites" },
            new Car { Id = 4, BrandId = 2, ColorId = 1, FuelTypeId = 1, Name = "Fiat Egea",
                ModelYear = 2020, DailyPrice= 280, Description = "Manuel Vites" },
            new Car { Id = 5, BrandId = 4, ColorId = 3, FuelTypeId = 3, Name = "Honda Civic",
                ModelYear = 2021, DailyPrice= 400, Description = "Otomatik Vites" },
            new Car { Id = 6, BrandId = 5, ColorId = 2, FuelTypeId = 4, Name = "Porche Taycan",
                ModelYear = 2020, DailyPrice= 750, Description = "Otomatik Vites" },
            new Car { Id = 7, BrandId = 1, ColorId = 4, FuelTypeId = 2, Name = "Ford Fiesta",
                ModelYear = 2014, DailyPrice= 200, Description = "Manuel Vites" },
            new Car { Id = 8, BrandId = 6, ColorId = 5, FuelTypeId = 3, Name = "Volkswagen Golf",
                ModelYear = 2022, DailyPrice= 500, Description = "Otomatik Vites" },
            new Car { Id = 8, BrandId = 6, ColorId = 5, FuelTypeId = 2, Name = "Volkswagen Polo",
                ModelYear = 2017, DailyPrice= 340, Description = "Manuel Vites" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car DeleteCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(DeleteCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updateCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateCar.Id = car.Id;
            updateCar.BrandId = car.BrandId;
            updateCar.ColorId = car.ColorId;
            updateCar.FuelTypeId = car.FuelTypeId;
            updateCar.Name = car.Name;
            updateCar.ModelYear = car.ModelYear;
            updateCar.Description = car.Description;
            updateCar.DailyPrice = car.DailyPrice;
        }
    }
}
