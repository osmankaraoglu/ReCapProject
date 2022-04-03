using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFuelService
    {
        IResult Add(Fuel fuel);
        IResult Delete(Fuel fuel);
        IResult Update(Fuel fuel);
        IDataResult<List<Fuel>> GetAll();
        IDataResult<Fuel> GetById(int id);
    }
}
