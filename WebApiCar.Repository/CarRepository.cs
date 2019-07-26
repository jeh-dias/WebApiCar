
using System;
using System.Collections.Generic;
using WebApiCar.Domain;
using Repository.Base;
using WebApiCar.Repository.Query;
using Microsoft.Extensions.Configuration;

namespace WebApiCar.Repository
{
    public class CarRepository : Repository<Car>
    {
        public CarRepository(IConfiguration config): base (config) 
        {
        }

        public List<Car> GetCarByMarca(string marca)
        {
            return _list.FindAll(x => x.marca == marca);
        }
    }
}
