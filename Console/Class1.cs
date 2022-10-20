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
            // CarManager cm = new CarManager(new EfCarDal());
            BrandManager bm = new BrandManager(new EfBrandDal());
            foreach (var item in bm.GetAll())
            {
                System.Console.WriteLine(item.Name);
            }
            //cm.Add(new Car { BrandId=2, ColorId=2,DailyPrice=1200.50M,Description="ff",ModelYear="1996"});
            //foreach (var car in cm.GetCarsByBrandId(2))
            //{
            //    System.Console.WriteLine(car.Description);
            //}

        }
    }
}
