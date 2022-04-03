using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FuelManager : IFuelService
    {
        IFuelDal _fuelDal;
        public FuelManager(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }
        public IResult Add(Fuel fuel)
        {
            _fuelDal.Add(fuel);
            return new SuccessResult(Messages.FuelTypeAdded);
        }

        public IResult Delete(Fuel fuel)
        {
            _fuelDal.Delete(fuel);
            return new SuccessResult(Messages.FuelTypeDeleted);
        }
        public IResult Update(Fuel fuel)
        {
            _fuelDal.Update(fuel);
            return new SuccessResult(Messages.FuelTypeUpdated);
        }

        public IDataResult<List<Fuel>> GetAll()
        {
            return new SuccessDataResult<List<Fuel>>(_fuelDal.GetAll(), Messages.FuelTypesListed);
        }

        public IDataResult<Fuel> GetById(int id)
        {
            return new SuccessDataResult<Fuel>(_fuelDal.Get(b => b.Id == id));
        }
    }
}
