using Autosaloon.Classes;
using Autosaloon.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autosaloon;
namespace AutosaloonUnitTestProject
{
    [TestClass]
    public class AutosaloonTest
    {
        Avtosaloon avto = new Avtosaloon("Mav");

        [TestMethod]
        public void AvailabilityTest()
        {
            var car = new Car(avto, 3);
            car.Cost = 2000;
            car.MaximumNumberOfPassengers = 3;
            Assert.AreEqual(car.Availability,true);
        }
        [TestMethod]
        [ExpectedException(typeof(CarNumberException))]
        public void CarNumberExceptionTest()
        {
            var car = new Car(avto,0);
            car.Name = "asd";
            car.Cost = 2000;
            car.MaximumNumberOfPassengers = 3;
            Applications app = new UIApplicationsForDelayedDelivery("asd",car,20);
            app.СalculateCost();
        }
        [TestMethod]
        [ExpectedException(typeof(PurchaserNameException))]
        public void PurchaserNameExceptionTest()
        {
            var car = new Car(avto, 0);
            car.Name = "asd";
            car.Cost = 2000;
            car.MaximumNumberOfPassengers = 3;
            Applications app = new UIApplicationsForDelayedDelivery("", car, 20);
        }
        [TestMethod]
        public void SearchCarTest()
        {
            var car = new Car(avto, 0);
            car.Name = "asd";
            car.Cost = 2000;
            car.MaximumNumberOfPassengers = 3;
            Assert.AreEqual(car, avto.SearchCar("asd"));
        }
        [TestMethod]
        public void CalculateCostTest()
        {
            var car = new Car(avto, 3);
            car.Cost = 2000;
            car.MaximumNumberOfPassengers = 3;
            Applications app = new UIApplicationsForDelayedDelivery("asd", car, 20);
            app.СalculateCost();
            Assert.AreEqual(app.СalculateCost(),1600);
        }
    }
}
