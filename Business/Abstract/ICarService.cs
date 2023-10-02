using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        public IDataResult<List<Car>> GetAll();
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        public IDataResult<List<Car>> GetCarsByColorId(int colorId);
        public IDataResult<Car> GetCarById(int id);
        public IResult Add(AddCarDto car);
        public IResult Update(Car car);
        public IResult Delete(int id);
        public IDataResult<List<CarDetailDto>> GetCarDetails();

    }
}
