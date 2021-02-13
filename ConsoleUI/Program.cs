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

            //Car car1 = new Car
            //{              
            //    CarName = "A",
            //    ColorId = 2,
            //    BrandId = 1,
            //    DailyPrice = 65000,
            //    Descriptions = "New car of the year",
            //    ModelYear = 2021
            //};

            //Car car2 = new Car
            //{
            //    CarName = "HRWSO",
            //    CarId = 7,
            //    ColorId = 3,
            //    BrandId = 3,
            //    DailyPrice = 54000,
            //    Descriptions = "Huge discount for our customers",
            //    ModelYear = 2015
            //};

            //Car car3 = new Car
            //{
            //    CarId = 6,
            //};


            //carManager.Delete(car3);

            //CarManager carManager = new CarManager(new EfCarDal());

            //var result1 = carManager.Update(car2);
            //var result = carManager.Add(car1);
            // carManager.Delete(car3);

            //foreach (var car in carManager.GetAll().Data)
            //{
            //    Console.WriteLine("Id of the car :" + car.CarId);
            //    Console.WriteLine("Name of the car : " + car.CarName);
            //    Console.WriteLine("BrandId of the car :" + car.BrandId);
            //    Console.WriteLine("Model Year of the car : " + car.ModelYear);
            //    Console.WriteLine("Description : " + car.Descriptions);
            //    Console.WriteLine("Price of the car : " + car.DailyPrice);
            //    Console.WriteLine("------------------");
            //}

            //Console.WriteLine(result.Message);
            //Console.WriteLine(result1.Message);
            //CarManager carManager1 = new CarManager(new EfCarDal());

            //foreach (var car in carManager1.GetCarDetails().Data)
            //{
            //    Console.WriteLine("Car name is :" + car.CarName);
            //    Console.WriteLine("Brand of the Car : " + car.BrandName);
            //    Console.WriteLine("Color of the Car : " + car.ColorName);
            //    Console.WriteLine("Price of the car : " + car.DailyPrice);
            //    Console.WriteLine("------------------");
            //}

            //Customer customer1 = new Customer
            //{
            //    UserId =6,
            //    CompanyName ="HUIOGF"
            //};

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(customer1);

            //Rental rental1 = new Rental()
            //{
            //    CarId = 8010,
            //    CustomerId = 4,
            //    RentDate = DateTime.Now.AddDays(-5),
            //    ReturnDate = DateTime.Now
            //};

            Rental rental2 = new Rental()
            {
                CarId = 7,
                CustomerId = 4,
                RentDate = DateTime.Now.AddDays(-5),
                ReturnDate = DateTime.Now
            };
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var res2 = rentalManager.Add(rental2);
            Console.WriteLine(res2.Message);

            var result = rentalManager.GetRentalDetails();
            Console.WriteLine(result.Message);

            foreach (var rental in result.Data)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Brand Name : " + rental.BrandName);
                Console.WriteLine("Car Name : " + rental.CarName);
                Console.WriteLine("User First Name : " + rental.UserFirstName);
                Console.WriteLine("User Last Name : " + rental.UserLastName);
                Console.WriteLine("Company Name : " + rental.CompanyName);
                Console.WriteLine("Rent Date : " + rental.RentDate);
                Console.WriteLine("Return Date : " + rental.ReturnDate);
            }

        }
    }
}
