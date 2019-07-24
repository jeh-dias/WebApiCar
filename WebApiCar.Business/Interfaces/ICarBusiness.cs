using System;
using System.Collections.Generic;
using System.Text;
using WebApiCar.Domain;

namespace WebApiCar.Business.Interfaces
{
    public interface ICarBusiness
    {
        bool Add(Car car);

        Car GetCarByMarca(string marca);
        List<Car> GetList();
    }
}
