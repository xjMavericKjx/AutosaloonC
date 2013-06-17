using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosaloon
{
    public class Car
    {
        public string Name { get; set; }
        public int MaximumNumberOfPassengers { get; set; }
        public int Cost { get; set; }
        public int QuantityInStock { get; set; }
        public bool Availability { get; private set; }
        private Avtosaloon Aulotasoon;
        private ArrayList ApplicationsForPurchase = new ArrayList();

        public Car(bool availability)
        {
            Availability = availability;
        }

        public ArrayList GetCars()
        {
            return ApplicationsForPurchase;
        }

        public void AddCar(Car car)
        {
            ApplicationsForPurchase.Add(car);
        }

        public void RemoveCar(Car car)
        {
            ApplicationsForPurchase.Remove(car);
        }

    }
}
