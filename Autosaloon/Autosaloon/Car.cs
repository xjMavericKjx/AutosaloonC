using System;
using System.Collections;

namespace Autosaloon
{
    [Serializable]
    public class Car
    {
        public string Name { get; set; }
        public int MaximumNumberOfPassengers { get; set; }
        public int Cost { get; set; }
        public int QuantityInStock { get; set; }
        public bool Availability { get; private set; }
        public Avtosaloon Autosaloon { get; private set; }
        private readonly ArrayList _applicationsForPurchase = new ArrayList();

        public Car(Avtosaloon aulotasoon, int quantityInStock)
        {
            Autosaloon = aulotasoon;
            QuantityInStock = quantityInStock;
            Autosaloon.AddCar(this);
            Availability = QuantityInStock != 0;
        }

        public ArrayList GetApplications()
        {
            return _applicationsForPurchase;
        }

        public void AddApplication(Applications application)
        {
            _applicationsForPurchase.Add(application);
        }

        public void RemoveApplication(Applications application)
        {
            _applicationsForPurchase.Remove(application);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
