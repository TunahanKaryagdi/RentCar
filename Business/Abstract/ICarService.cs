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
        public List<Car> GetAll();

        public List<Car> GetCarsByBrandId(int brandId);
        public List<Car> GetCarsByColorId(int colorId); 

        public void Add(Car car);

        public List<CarDetailDto> GetCarDetails();

    }
}
