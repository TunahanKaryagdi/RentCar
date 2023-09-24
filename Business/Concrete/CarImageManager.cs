using Business.Abstract;
using Business.Constants;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {

        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;


        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage carImage ,int carId)
        {
            IResult result = CheckIfCarImageLimit(carImage.CarId);
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = _fileHelper.Upload(file, FilePath.ImagesPath);
            carImage.Date = DateTime.Now;
            carImage.CarId = carId;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(CarImage image)
        {
            _fileHelper.Delete(image.ImagePath);
            _carImageDal.Delete(image);
            return new SuccessResult();
        }

        public IResult Update(IFormFile file, CarImage carImage ,int carId)
        {
            carImage.ImagePath = _fileHelper.Update(file, FilePath.ImagesPath + carImage.ImagePath, FilePath.ImagesPath);
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        public IResult CheckIfCarImageLimit(int carId)
        {
            int imageCount = _carImageDal.GetAll(i => i.CarId == carId).Count;
            if (imageCount >= 5)
            {
                return new ErrorResult(Messages.NoLimit);
            }
            return new SuccessResult();
        }
    }
}
