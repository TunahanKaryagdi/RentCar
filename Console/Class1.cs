using Business.Concrete;
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
            CarManager cm = new CarManager(new InMemoryCarDal());

            foreach (var car in cm.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }

        }
    }
}
