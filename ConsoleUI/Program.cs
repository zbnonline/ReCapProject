using Business.Concrete;
using DataAccess.Abstract;
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
            //GetAllCars();

            //AddCar();
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {
                CarId = 6,
                BrandId = 3,
                ColorId = 4,
                CarName = "A3 Sportback",
                DailyPrice = 199,
                ModelYear = "2019",
                Description = "Aileler için uygun"
            });
        }

        private static void GetAllCars()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.CarDetails())
            {
                Console.WriteLine($"Car: {car.CarName} | Brand: {car.BrandName} | Color: {car.ColorName} | DailyPrice: " +
                    $"{car.DailyPrice} | Description: {car.Description}");
            }
        }
    }
}
