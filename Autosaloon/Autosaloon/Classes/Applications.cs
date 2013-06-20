using System;
using System.Windows.Forms;
using Autosaloon.Exceptions;

namespace Autosaloon.Classes
{
    [Serializable]
    public abstract class Applications
    {
        public string NameOfBuyer { get; set; }
        public string CellNumber { get; set; }
        public Car Car { get; set; }

        protected Applications(string nameOfBuyer,Car car)
        {
            try
            {
                if (string.IsNullOrEmpty(nameOfBuyer)) throw new PurchaserNameException("Неуказано имя покупателя!");
                NameOfBuyer = nameOfBuyer;
            }
            catch (PurchaserNameException ex)
            {
                MessageBox.Show("" + ex);
            }
            Car = car;
            Car.AddApplication(this);
        }

        public abstract override string ToString();

        public abstract int СalculateCost();
    }



}
