using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void AddCar(Car car);
        void DeleteCar(Car car);

        void UpdateCar(Car car);


    }
}
