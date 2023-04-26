using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Class1
    {
        public static void Main(String[] args)
        {
            CarManager cm = new CarManager(new EfCarDal());
            UserManager um = new UserManager(new EfUserDal());
            //BrandManager bm = new BrandManager(new EfBrandDal());
            System.Console.WriteLine(cm.GetCarDetails().Data.Count);
            //foreach (var item in um.GetAll().Data)
            //{
            //    System.Console.WriteLine(item.FirstName); ;
            //}
            //foreach (var car in cm.GetCarsByBrandId(2))
            //{
            //    System.Console.WriteLine(car.Description);
            //}

        }
    }
}
