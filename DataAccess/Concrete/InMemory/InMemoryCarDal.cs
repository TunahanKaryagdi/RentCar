﻿using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 400, Description = "comfort", ModelYear="2022" },
                new Car{ Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 500, Description = "economic", ModelYear="1996" },
                new Car{ Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 200, Description = "silence", ModelYear="2020" },
                new Car{ Id = 4, BrandId = 4, ColorId = 5, DailyPrice = 300, Description = "hard", ModelYear="2002" },
                new Car{ Id = 5, BrandId = 3, ColorId = 5, DailyPrice = 100, Description = "fast", ModelYear="2015" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return (Car)_cars.Where(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
        }
    }
    }
 
