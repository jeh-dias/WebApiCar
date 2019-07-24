using System;
using System.Collections.Generic;
using WebApiCar.Business.Interfaces;
using WebApiCar.Domain;
using WebApiCar.Repository;

namespace WebApiCar.Business
{
    public class CarBusiness : ICarBusiness
    {
        private CarRepository _carRepository;
        public CarBusiness()
        {
            _carRepository = new CarRepository();
        }

        public bool Add(Car car)
        {
            _carRepository.Add(car);
            return true;

        }

        public List<Car> GetList()
        {
            return _carRepository.GetList();
        }

        public Car GetCarByMarca(string marca)
        {
            return _carRepository.GetCarByMarca(marca);
        }
    }
}
