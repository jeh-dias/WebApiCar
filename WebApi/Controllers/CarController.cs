using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCar.Business;
using WebApiCar.Domain;
using WebApiCar.Services;
using WebApiCar.Services.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarServices _carServices;

        public CarController(ICarServices carServices)
        {
            _carServices = carServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            return _carServices.List();
        }

        [HttpGet("{marca}")]
        public ActionResult<Car> Get(string marca)
        {
            return _carServices.GetByMarca(marca);
        }

        [HttpPost]
        public void Post([FromBody] Car car)
        {
            _carServices.Insert(car);
        }
    }
}
