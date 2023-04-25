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
            //BrandManager bm = new BrandManager(new EfBrandDal());
            System.Console.WriteLine(cm.GetAll().Message);
            foreach (var item in cm.GetAll().Data)
            {
                System.Console.WriteLine(item.Description); ;
            }
            //foreach (var car in cm.GetCarsByBrandId(2))
            //{
            //    System.Console.WriteLine(car.Description);
            //}

        }
    }
}
