using Repository.Interface;
using System;
using System.Collections.Generic;
using WebApiCar.Business.Interfaces;
using WebApiCar.Domain;
using WebApiCar.Repository;

namespace WebApiCar.Business
{
    public class CarBusiness : ICarBusiness
    {
        private IRepository<Car> _carRepository;
        public CarBusiness(IRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public bool Add(Car car)
        {
            _carRepository.Add(car);
            return true;

        }

        public IEnumerable<Car> GetList()
        {
            return _carRepository.List();
            //return _carRepository.ListAll();
        }

        public List<Car> GetCarByMarca(string marca)
        {
            //return _carRepository.GetCarByMarca(marca);
            return null;
        }
    }
}
