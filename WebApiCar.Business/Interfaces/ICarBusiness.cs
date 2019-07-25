using System;
using System.Collections.Generic;
using System.Text;
using WebApiCar.Domain;

namespace WebApiCar.Business.Interfaces
{
    public interface ICarBusiness
    {
        bool Add(Car car);

        List<Car> GetCarByMarca(string marca);
        IEnumerable<Car> GetList();
    }
}
