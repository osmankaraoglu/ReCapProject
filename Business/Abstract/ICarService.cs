using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();
        List<Car> GetByAllBrandId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByAllColor(int id);
        List<Car> GetByFuelType(int id);

    }
}
