
using System;
using System.Collections.Generic;
using WebApiCar.Domain;
using Repository.Base;
using WebApiCar.Repository.Query;

namespace WebApiCar.Repository
{
    public class CarRepository : Repository<Car>
    {

        public List<Car> GetCarByMarca(string marca)
        {
            return _list.FindAll(x => x.marca == marca);
        }

        public IEnumerable<Car> ListAll()
        {
            return new CarQuery().GetCars();
        }
    }
}
