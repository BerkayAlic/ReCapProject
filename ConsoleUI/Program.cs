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
            
        }
    }
}
