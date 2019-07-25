
using System;
using System.Collections.Generic;
using WebApiCar.Domain;
using Repository.Base;

namespace WebApiCar.Repository
{
    public class CarRepository : Repository<Car>
    {

        public List<Car> GetCarByMarca(string marca)
        {
            return _list.FindAll(x => x.marca == marca);
        }
    }
}
