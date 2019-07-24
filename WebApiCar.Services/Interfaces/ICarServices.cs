using System;
using System.Collections.Generic;
using System.Text;
using WebApiCar.Domain;

namespace WebApiCar.Services.Interfaces
{
    public interface ICarServices
    {
        List<Car> List();

        List<Car> Insert(Car car);

        Car GetByMarca(string marca);
    }
}
