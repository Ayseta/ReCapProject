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
            Console.WriteLine("Filo:");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId+brand.BrandName);
            }

            Console.WriteLine("\n" + "Araçları açıklama ve günlük fiyata göre listele:");
            
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "\t" + car.DailyPrice);
            }

            Console.WriteLine("\n" + "2 numaralı araçların sınıf ve modeli:");

            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.CarName);
            }

            Console.WriteLine("\n" + "Beyaz olan araçların sınıf ve modeli:");

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.ColorId);
            }
            Console.WriteLine("\n");
            carManager.Add(new Car() { BrandId = 1, ColorId = 1, ModelYear = 2000, DailyPrice = 0, Description = "Ekonomik", CarName = "Sedan" });
            Console.WriteLine("\t");
            Console.WriteLine("Mevcut araçlar listesi:");

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "\t " + car.CarName + "\t\t\n " + car.ColorName + "\t  " +  car.DailyPrice+"Tl");
            }
        }
    }
}
