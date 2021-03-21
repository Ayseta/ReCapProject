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
            CarManager carManager = new CarManager(new EfCarDal());
          

            Console.WriteLine("\n" + "Araçları açıklama ve günlük fiyata göre listele");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "\t" +car.DailyPrice);
            }

            Console.WriteLine("\n" + "2 numaralı araçların sınıf ve modeli");

            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.CarName);
            }

            Console.WriteLine("\n" + "Beyaz olan araçların sınıf ve modeli");

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.ColorId);
            }
            Console.WriteLine("\n");
            carManager.Add(new Car() {BrandId = 1, ColorId = 1, ModelYear = 2000, DailyPrice =0, Description = "Ekonomik", CarName="Sedan" });
        }
    }
}
