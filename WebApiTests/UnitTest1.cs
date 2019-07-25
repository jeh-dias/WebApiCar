using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace WebApiTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestControllerSucess()
        {
            //var carServices = new Mock<ICarServices>();

            //carServices.Setup(s => s.Add(It.IsAny<Car>()));

            //var produtoController = new ProdutoController(carServices.Object);

            //var result = produtoController.Post(new Car { Marca = "Nike", Nome = "Bamba" });

            //Assert.NotNull(result);
            //Assert.IsType<OkObjectResult>(result.Result);

            //var httpObjResult = result.Result as OkObjectResult;

            //Assert.NotNull(httpObjResult);
            //Assert.True(httpObjResult.StatusCode == 200);

            //var value = httpObjResult.Value;

            //Assert.NotNull(value);
            //Assert.False(string.IsNullOrWhiteSpace(value.ToString()));
            //Assert.Same("success", value);
        }
    }
}
