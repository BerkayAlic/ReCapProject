using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {           
            
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("BrandId of the car :" + car.BrandId);
                Console.WriteLine("Model Year of the car : " + car.ModelYear);
                Console.WriteLine("Description : " + car.Description);
                Console.WriteLine("Price of the car : " + car.DailyPrice);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("Our new car has been produced for our special customers");
            Console.WriteLine("The price of car which has Id = 3 has a discount it is very big oppurtunity");
            Console.WriteLine("The car which is id = 4 has been deleted");
            Console.WriteLine("Here is our new catalogue for our costomers");
            Console.WriteLine("---------------");

            Car car1 = new Car
                { Id=5,
                ColorId=7,
                BrandId=8, 
                DailyPrice=54000,
                Description = "Private car for elegant customers", 
                ModelYear=2020
            };
           
            Car car2 = new Car
            {
                Id = 3,
                ColorId = 2,
                BrandId = 3,
                DailyPrice = 65000,
                Description = "Huge discount for our customers",
                ModelYear = 2015
            };

            Car car3 = new Car
            {
                Id =4,
            };

            carManager.AddCar(car1);
            carManager.UpdateCar(car2);
            carManager.DeleteCar(car3);
                        
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("======");
                Console.WriteLine("BrandId of the car :" + car.BrandId);
                Console.WriteLine("Model Year of the car : " + car.ModelYear);
                Console.WriteLine("Description : " + car.Description);
                Console.WriteLine("Price of the car : " + car.DailyPrice);
                Console.WriteLine("------------------");
            }



        }
    }
}
