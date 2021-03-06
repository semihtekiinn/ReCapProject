using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=2, ModelYear=2015, DailyPrice=250000, Description="Beyaz 2015 Model Mercedes" },
                new Car{ Id=2, BrandId=1, ColorId=1, ModelYear=2013, DailyPrice=225000, Description="Siyah 2013 Model Mercedes" },
                new Car{ Id=3, BrandId=2, ColorId=3, ModelYear=2019, DailyPrice=310000, Description="Kırmızı 2019 Model BMW" },
                new Car{ Id=4, BrandId=2, ColorId=2, ModelYear=2014, DailyPrice=230000, Description="Beyaz 2014 Model BMW" },
                new Car{ Id=5, BrandId=2, ColorId=1, ModelYear=2020, DailyPrice=350000, Description="Siyah 2020 Model BMW" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
