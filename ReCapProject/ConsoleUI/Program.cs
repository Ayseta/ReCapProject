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
            BrandTest();
            CarTest();

            //GetCarsById();
            //GetCarsByColorId();

            //AddedTest();
            //DeleteTest();

            //GetCarDetailsTest();

        }
        private static void BrandTest()
        {
            Console.WriteLine("Filo:");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandId + brand.BrandName);
            }
        }

        private static void CarTest()
        {
            Console.WriteLine("\n" + "Araçları açıklama ve günlük fiyata göre listele:");

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
            Console.WriteLine("Mevcut araçlar listesi:");
            CarManager carManager = new CarManager(new EfCarDal());
            var result5 = carManager.GetCarDetails();
            foreach (var car in result5.Data)
            {
                Console.WriteLine(car.BrandName + "\t " + car.CarName + "\t\t\n " + car.ColorName + "\t  " + car.DailyPrice + "Tl");
            }
        }

        private static void DeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result4 = carManager.Delete(new Car { CarId = 6 });
            Console.WriteLine(result4.Message);
        }

        private static void AddedTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            var resul3 = carManager.Add(new Car { BrandId = 4, ColorId = 3, DailyPrice = 0, CarName = "None" });
            Console.WriteLine(resul3.Message);
        }

        private static void GetCarsByColorId()
        {
            Console.WriteLine("\n" + "Beyaz olan araçların sınıf ve modeli:");

            CarManager carManager = new CarManager(new EfCarDal());
            var result2 = carManager.GetCarsByColorId((1));
            foreach (var car in result2.Data)
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.ColorId);
            }
        }

        private static void GetCarsById()
        {
            Console.WriteLine("\n" + "2 numaralı araçların sınıf ve modeli:");
            CarManager carManager = new CarManager(new EfCarDal());
            var result1 = carManager.GetCarsByBrandId((3));
            foreach (var car in result1.Data)
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.CarName);
            }
        }
    }
}
