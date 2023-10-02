using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {

        IResult Add(IFormFile file, CarImage carImage, int carId );
        IResult Delete(CarImage image);
        IResult Update(IFormFile file,CarImage carImage, int carId);
        IDataResult<List<CarImage>> GetAll();


    }
}
