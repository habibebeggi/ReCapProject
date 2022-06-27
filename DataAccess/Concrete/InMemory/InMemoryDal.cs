using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICar
    {
        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car> {
            new Car {CarId=1,BrandId=2,ColorId=1,DailyPrice=24000,ModelYear=2004,Description="Doktordan satılık" } ,
            new Car {CarId=2,BrandId=3,ColorId=1,DailyPrice=23000,ModelYear=2014,Description="Çok Temiz değil" },
            new Car {CarId=3,BrandId=2,ColorId=1,DailyPrice=44000,ModelYear=2011,Description="Çok iyi durumda" },
            new Car {CarId=4,BrandId=4,ColorId=1,DailyPrice=29000,ModelYear=2024,Description="Çok çıtır Temiz" },
            new Car {CarId=5,BrandId=5,ColorId=1,DailyPrice=27000,ModelYear=2014,Description="Çok Temiz durumda " }};
        }

        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c=>c.BrandId==brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId= car.ColorId;
            carUpdate.DailyPrice= car.DailyPrice;
            carUpdate.Description= car.Description;
        }
    }
}
