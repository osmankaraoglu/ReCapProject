using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetByAllBrandId(int id);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetByAllColor(int id);
        IDataResult<List<Car>> GetByFuelType(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();

    }
}
