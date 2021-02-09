using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryCarDal : ICarDal
    {
        public List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=53000, ModelYear=2013, Descriptions="Manual,Diesel"},
                new Car{CarId=2, BrandId=2, ColorId=2, DailyPrice=12000, ModelYear=2018, Descriptions="Hybrid"},
                new Car{CarId=3, BrandId=3, ColorId=2, DailyPrice=71000, ModelYear=2015, Descriptions="Sedan,Large Baggage"},
                new Car{CarId=4, BrandId=4, ColorId=3, DailyPrice=34000, ModelYear=2010, Descriptions="Manual,Gasoline"},
            };
        }

        
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c=>car.CarId == c.CarId);
            _cars.Remove(CarToDelete);
            Console.WriteLine(car.CarId + ".Car is deleted");
            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }



        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {

            Car CarWillBeUpdated = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarWillBeUpdated.BrandId = car.BrandId;
            CarWillBeUpdated.ColorId = car.ColorId;
            CarWillBeUpdated.DailyPrice = car.DailyPrice;
            CarWillBeUpdated.ModelYear = car.ModelYear;
            CarWillBeUpdated.Descriptions = car.Descriptions;

        }
    }
}
