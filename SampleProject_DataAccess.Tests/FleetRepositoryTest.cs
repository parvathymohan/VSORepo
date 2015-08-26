using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProject_DataAccess.Repository;

namespace SampleProject_DataAccess.Tests
{
    [TestClass]
    public class FleetRepositoryTest
    {
        [TestMethod]
        public void GetByIdTestValidId()
        {
            FleetContext fleetContext = new FleetContext();

            FleetRepository fleetRepository = new FleetRepository(fleetContext);

           var fleetFiles =  fleetRepository.GetByID(1);

           Assert.IsTrue(fleetFiles.HeaderId==1);

        }

        [TestMethod]
        public void GetByIdTestInvalidId()
        {
            FleetContext fleetContext = new FleetContext();

            FleetRepository fleetRepository = new FleetRepository(fleetContext);

            var fleetFiles = fleetRepository.GetByID(3231);

            Assert.IsNull(fleetFiles);

        }
    }
}
