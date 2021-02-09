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

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("BrandId of the car :" + car.BrandId);
                Console.WriteLine("Model Year of the car : " + car.ModelYear);
                Console.WriteLine("Description : " + car.Descriptions);
                Console.WriteLine("Price of the car : " + car.DailyPrice);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("Our new car has been produced for our special customers");
            Console.WriteLine("The price of car which has Id = 2 has a discount it is very big oppurtunity");
            Console.WriteLine("The car which is id = 3 has been deleted");
            Console.WriteLine("Here is our new catalogue for our costomers");
            Console.WriteLine("---------------");

            Car car1 = new Car
            {
                CarName = "LKA",                
                ColorId = 2,
                BrandId = 3,
                DailyPrice = 54000,
                Descriptions = "Private car for elegant customers",
                ModelYear = 2020
            };

            Car car2 = new Car
            {
                CarName = "HRWSO",
                CarId = 2,
                ColorId = 3,
                BrandId = 3,
                DailyPrice = 54000,
                Descriptions = "Huge discount for our customers",
                ModelYear = 2015
            };

            Car car3 = new Car
            {
                CarId = 3,
            };

            carManager.Add(car1);
            carManager.Update(car2);
            carManager.Delete(car3);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("======");
                Console.WriteLine("BrandId of the car :" + car.BrandId);
                Console.WriteLine("Model Year of the car : " + car.ModelYear);
                Console.WriteLine("Description : " + car.Descriptions);
                Console.WriteLine("Price of the car : " + car.DailyPrice);
                Console.WriteLine("------------------");
            }

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //foreach (var color in colorManager.GetAll())
            //{
            // Console.WriteLine(color.ColorName);
            //Console.WriteLine(color.ColorId);
            //}

            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            
            CarManager carManager1 = new CarManager(new EfCarDal());

            foreach (var car in carManager1.GetCarDetails())
            {
                Console.WriteLine("Car name is :" + car.CarName);
                Console.WriteLine("Brand of the Car : " + car.BrandName);
                Console.WriteLine("Color of the Car : " + car.ColorName);
                Console.WriteLine("Price of the car : " + car.DailyPrice);
                Console.WriteLine("------------------");
            }
        }
    }
}
