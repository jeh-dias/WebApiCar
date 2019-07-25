using System;
using System.Collections.Generic;
using System.Text;
using WebApiCar.Domain;

namespace WebApiCar.Services.Interfaces
{
    public interface ICarServices
    {
        IEnumerable<Car> List();

        IEnumerable<Car> Insert(Car car);

        List<Car> GetByMarca(string marca);
    }
}
