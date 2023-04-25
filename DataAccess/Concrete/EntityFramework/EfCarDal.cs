using Core.DataAccess.EntityFramework;
using Core.Entity;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from cr in context.Cars
                             join cl in context.Colors
                             on cr.ColorId equals cl.Id
                             join br in context.Brands
                             on cr.BrandId equals br.Id 
                             select new CarDetailDto
                             {
                                 CarId = cr.Id,
                                 CarName = br.Name,
                                 BrandName = br.Name,
                                 ColorName = cl.Name,
                                 DailyPrice = cr.DailyPrice
                             };


                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
