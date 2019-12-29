using System;
using Xunit;
using System.Linq;
using Moq;
using MyFabricStashWebAppCore4.Controllers;
using MyFabricStashWebAppCore4.Models;
using System.Collections.Generic;

namespace MyFabricStashWebAppCore4.Tests
{
    public class FabricControllerTests
    {
        [Fact]
        public void CanPaginate()
        {
            //Arrange
            Mock<IFabricRepository> mock = new Mock<IFabricRepository>();
            mock.Setup(m => m.Fabrics).Returns((new Fabric[]
            {
                new Fabric {FabricId = 1, Name = "F1"},
                new Fabric {FabricId = 2, Name = "F2"},
                new Fabric {FabricId = 3, Name = "F3"},
                new Fabric {FabricId = 4, Name = "F4"},
                new Fabric {FabricId = 5, Name = "F5"}
            }).AsQueryable<Fabric>());

            FabricController controller = new FabricController(mock.Object);
            controller.PageSize = 3;

            //Act
            IEnumerable<Fabric> result = controller.List(2).ViewData.Model as IEnumerable<Fabric>;

            //Assert
            Fabric[] fabricArray = result.ToArray();
            Assert.True(fabricArray.Length == 2);
            Assert.Equal("F4", fabricArray[0].Name);
            Assert.Equal("F5", fabricArray[1].Name);

        }
    }
}
