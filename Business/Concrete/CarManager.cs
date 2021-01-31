﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void AddCar(Car car)
        {
            _carDal.Add(car);
        }

        public void DeleteCar(Car car)
        {
            Console.WriteLine("The car which is older model then 2011 is removed");
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void UpdateCar(Car car)
        {
            _carDal.Update(car);
        }
    }
}
