using System;
using System.Collections.Generic;
using WebApiCar.Business.Interfaces;
using WebApiCar.Domain;
using WebApiCar.Repository;
using WebApiCar.Services.Interfaces;

namespace WebApiCar.Services
{
    public class CarServices : ICarServices
    {
        private readonly ICarBusiness _carBusiness;

        public CarServices(ICarBusiness carBusiness)
        {
            _carBusiness = carBusiness;
        }
        public List<Car> List()
        {
            return _carBusiness.GetList();
        }

        public Car GetByMarca(string marca)
        {
            return _carBusiness.GetCarByMarca(marca);
        }

        public List<Car> Insert(Car car)
        {
            _carBusiness.Add(car);
            return _carBusiness.GetList();
        }
    }
}
