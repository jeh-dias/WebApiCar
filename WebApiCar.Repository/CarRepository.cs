
using System;
using System.Collections.Generic;
using WebApiCar.Domain;
using Repository.Base;

namespace WebApiCar.Repository
{
    public class CarRepository : Repository<Car>
    {

        public Car GetCarByMarca(string marca)
        {
            return _list.Find(x => x.marca == marca);
        }
    }
}
