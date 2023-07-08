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
            //GetCarDetails();

            //AddCar();

            //DeleteCar();
        }

        private static void DeleteCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.Delete(new Car
            {
                CarId = 6,
                BrandId = 3,
                ColorId = 4,
                CarName = "A3",
                ModelYear = "2019",
                DailyPrice = 199,
                Description = "Aileler için uygun"
            });

            Console.WriteLine(result.Message);
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {
                CarId = 7,
                BrandId = 3,
                ColorId = 4,
                CarName = "A3",
                DailyPrice = 199,
                ModelYear = "2019",
                Description = "Aileler için uygun"
            });

        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.CarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"Car: {car.CarName} | Brand: {car.BrandName} | Color: {car.ColorName} | DailyPrice: " +
                        $"{car.DailyPrice} | Description: {car.Description}");
                }
            } else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
