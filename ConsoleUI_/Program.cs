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
                Console.WriteLine("Araç ID: {0} , Araç Model Yılı: {1} , Araç Marka ID: {2} , Araç Renk ID: {3} , Araç Günlük Fiyat: {4} ",car.CarId, car.ModelYear, car.BrandId, car.ColorId, car.DailyPrice);
            }
        }
    }
}
