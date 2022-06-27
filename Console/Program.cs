using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
     class Program
    {
        static void Main(string[] Args)
        {
            CarManager carManager = new CarManager(new InMemoryDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
            }
        }
    }
}
