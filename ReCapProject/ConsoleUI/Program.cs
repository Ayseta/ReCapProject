using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main (string[] args)

        {
            UserTest();

            //CustomerTest();

            //RentalTest();

            //GetRentailDetailsTest();


            //BrandTest();
            //CarTest();

            //GetCarsById();
            //GetCarsByColorId();

            //CarAddTest();
            //CarDeleteTest();

            //GetCarDetailsTest();

            //GetAll();

        }

        private static void GetAll()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result10 = userManager.GetAll();
            foreach (var user in result10.Data)
            {
                Console.WriteLine(user.FirstName + user.LastName);
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result8 = rentalManager.Add(new Rental
            { CustomerId = 1, CarId = 3, RentDate = DateTime.Now, ReturnDate = new DateTime(2021, 4, 8) });
            Console.WriteLine(result8.Message);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result7 = customerManager.Add(new Customer { UserId = 3, CompanyName = "Argun Holding" });
            Console.WriteLine(result7.Message);

            //var result11 = customerManager.Delete(new Customer { CustomerId = 4});
            //Console.WriteLine(result11.Message);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result6 = userManager.Add(new User
            { FirstName = "Yıldız", LastName = "Argun", Email = "yildiz@mail.com", Password = "6547" });
            Console.WriteLine(result6.Message);

            //var result12 = userManager.Delete(new User { UserId = 4 });
            //Console.WriteLine(result12.Message);

        }

        private static void GetRentailDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result9 = rentalManager.GetRentalDetails();
            if (result9.Success==false)
            {
                foreach (var rental in result9.Data)
                {
                    Console.WriteLine(rental.UserName + rental.RentDate + "\t " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result9.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandId + brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "\t\n" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result5 = carManager.GetCarDetails();
            foreach (var car in result5.Data)
            {
                Console.WriteLine(car.BrandName + "\t " + car.CarName + "\t\t\n " + car.ColorName + "\t  " + car.DailyPrice + "Tl");
            }
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result4 = carManager.Delete(new Car { CarId = 2010 });
            Console.WriteLine(result4.Message);
        }

        private static void CarAddTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            var resul3 = carManager.Add(new Car { BrandId = 4, ColorId = 3, ModelYear=2021, DailyPrice =1500, Description="Premium", CarName="M Sport"});
            Console.WriteLine(resul3.Message);
        }

        private static void GetCarsByColorId()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            var result2 = carManager.GetCarsByColorId((1));
            foreach (var car in result2.Data)
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.ColorId);
            }
        }

        private static void GetCarsById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result1 = carManager.GetCarsByBrandId((3));
            foreach (var car in result1.Data)
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.CarName);
            }
        }
    }
}
