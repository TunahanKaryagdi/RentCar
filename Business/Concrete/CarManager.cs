using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        ICarImageService _carImageService;

        public CarManager(ICarDal carDal,ICarImageService carImageService)
        {
            _carDal = carDal;   
            _carImageService = carImageService;
        }



        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(AddCarDto car)
        {
            Car carToAdd = new Car {
                BrandId = car.BrandId, 
                ColorId = car.ColorId, 
                DailyPrice = car.DailyPrice, 
                Description = car.Description, 
                ModelYear = car.ModelYear
            };
            _carDal.Add(carToAdd);

            CarImage carImage = new CarImage();
            _carImageService.Add(car.file, carImage, carToAdd.Id);
            return new SuccessResult(Messages.okey);

        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(int id)
        {
            Car carToDelete = _carDal.Get(c => c.Id == id);
            _carDal.Delete(carToDelete);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.okey);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.okey);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId), Messages.okey);
   
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId), Messages.okey);
        }

        public IDataResult<Car> GetCarById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id), Messages.okey);
        }
    }
}
