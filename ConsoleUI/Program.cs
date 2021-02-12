using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car
            {              
                CarName = "A",
                ColorId = 2,
                BrandId = 1,
                DailyPrice = 65000,
                Descriptions = "New car of the year",
                ModelYear = 2021
            };

            Car car2 = new Car
            {
                CarName = "HRWSO",
                CarId = 7,
                ColorId = 3,
                BrandId = 3,
                DailyPrice = 54000,
                Descriptions = "Huge discount for our customers",
                ModelYear = 2015
            };

            Car car3 = new Car
            {
                CarId = 6,
            };

            
            //carManager.Delete(car3);

            CarManager carManager = new CarManager(new EfCarDal());

            var result1 = carManager.Update(car2);
            var result = carManager.Add(car1);
            // carManager.Delete(car3);

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Id of the car :" + car.CarId);
                Console.WriteLine("Name of the car : " + car.CarName);
                Console.WriteLine("BrandId of the car :" + car.BrandId);
                Console.WriteLine("Model Year of the car : " + car.ModelYear);
                Console.WriteLine("Description : " + car.Descriptions);
                Console.WriteLine("Price of the car : " + car.DailyPrice);
                Console.WriteLine("------------------");
            }

            Console.WriteLine(result.Message);
            Console.WriteLine(result1.Message);
            //CarManager carManager1 = new CarManager(new EfCarDal());

            //foreach (var car in carManager1.GetCarDetails().Data)
            //{
            //    Console.WriteLine("Car name is :" + car.CarName);
            //    Console.WriteLine("Brand of the Car : " + car.BrandName);
            //    Console.WriteLine("Color of the Car : " + car.ColorName);
            //    Console.WriteLine("Price of the car : " + car.DailyPrice);
            //    Console.WriteLine("------------------");
            //}
        }
    }
}
