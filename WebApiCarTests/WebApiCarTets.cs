using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using WebApi.Controllers;
using WebApiCar.Domain;
using WebApiCar.Services.Interfaces;
using Xunit;

namespace WebApiCarTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var carServices = new Mock<ICarServices>();

            carServices.Setup(s => s.Insert(It.IsAny<Car>()));

            var carController = new CarController(carServices.Object);

            var result = carController.Post(new Car { marca = "Nike", ano = "2018", modelo =  "celta" });

            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result.Result);

            var httpObjResult = result.Result as OkObjectResult;

            Assert.NotNull(httpObjResult);
            Assert.True(httpObjResult.StatusCode == 200);

            var value = httpObjResult.Value;

            Assert.NotNull(value);
            Assert.False(string.IsNullOrWhiteSpace(value.ToString()));
            Assert.Same("success", value);
        }
    }
}
