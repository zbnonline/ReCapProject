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

            //GetAllUsers();

            //AddCustomer();

            //AddRental();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.RentalDetails();

            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine($"Araba: {rental.CarName} / Günlük Fiyat: {rental.DailyPrice} " +
                        $"/ Kiralayan Adı Soyadı: {rental.FirstName + " " + rental.LastName} " +
                        $"/ Email: {rental.Email} / Şirket: {rental.CompanyName}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                RentalId = 2,
                CarId = 3,
                CustomerId = 2,
                RentDate = new DateTime(2023, 05, 17),
                ReturnDate = new DateTime(2023, 06, 28)
            });
        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                CustomerId = 3,
                UserId = 4,
                CompanyName = "Ağdeve Müşavirlik"
            });
        }

        private static void GetAllUsers()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            //var result = userManager.GetAll();

            //foreach (var user in result.Data)
            //{
            //    Console.WriteLine(user.FirstName + " " + user.LastName);
            //}
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
