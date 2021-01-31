using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=53000, ModelYear=2013, Description="Manual,Diesel"},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=120000, ModelYear=2018, Description="Hybrid"},
                new Car{Id=3, BrandId=3, ColorId=2, DailyPrice=71000, ModelYear=2015, Description="Sedan,Large Baggage"},
                new Car{Id=4, BrandId=4, ColorId=3, DailyPrice=34000, ModelYear=2010, Description="Manual,Gasoline"},
            };
        }

        
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c=>car.Id == c.Id);
            Console.WriteLine(car.Id + "Car is deleted");
            
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {

            Car CarWillBeUpdated = new Car();
            CarWillBeUpdated.BrandId = car.BrandId;
            CarWillBeUpdated.ColorId = car.ColorId;
            CarWillBeUpdated.DailyPrice = car.DailyPrice;
            CarWillBeUpdated.ModelYear = car.ModelYear;
            CarWillBeUpdated.Description = car.Description;


        }
    }
}
