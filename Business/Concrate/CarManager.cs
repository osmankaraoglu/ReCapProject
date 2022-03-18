using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.Name.Length >= 2 && car.DailyPrice > 1)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba Eklemesi Başarılı!");
            }
            else
            {
                Console.WriteLine("Araba eklenemedi. Araba adı minimum 2 karakter olmalıdır ve günlük ücret 0'dan büyük olmalıdır!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByAllBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetByAllColor(int id)
        {
            return _carDal.GetAll(c => c.ColorId== id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => (c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public List<Car> GetByFuelType(int id)
        {
            return _carDal.GetAll(c => c.FuelTypeId == id);
        }
    }
}
