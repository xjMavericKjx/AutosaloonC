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
        public Avtosaloon Aulotasoon { get; private set; }
        private readonly ArrayList _applicationsForPurchase = new ArrayList();

        public Car(Avtosaloon aulotasoon)
        {
            Aulotasoon = aulotasoon;
            Availability = QuantityInStock != 0;
        }

        public ArrayList GetApplications()
        {
            return _applicationsForPurchase;
        }

        public void AddCar(Application car)
        {
            _applicationsForPurchase.Add(car);
        }

        public void RemoveCar(Application car)
        {
            _applicationsForPurchase.Remove(car);
        }

    }
}
