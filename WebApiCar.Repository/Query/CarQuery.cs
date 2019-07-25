using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiCar.Domain;
using WebApiCar.Repository.Utilities;

namespace WebApiCar.Repository.Query
{
    public class CarQuery
    {
        private string query = "select * from Car";

        public IEnumerable<Car> GetCar()
        {
            return ConnectionFactory.GetConnection().Query<Car>(query);
        }
    }
}
