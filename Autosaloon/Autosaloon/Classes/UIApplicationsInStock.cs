using System;
using System.Windows.Forms;
using Autosaloon.Exceptions;

namespace Autosaloon.Classes
{
    [Serializable]
    public class UIApplicationsInStock : Applications
    {

        public UIApplicationsInStock(String nameOfBuyer, Car car)
            : base(nameOfBuyer, car)
        {
        }

        public override int СalculateCost()
        {
            try
            {
                if (Car.QuantityInStock == 0) throw new CarNumberException("Машина отсутствует на складе");
                return Car.Cost;
            }
            catch (CarNumberException ex)
            {
                MessageBox.Show("" + ex);
                throw;
            }
        }

        public override string ToString()
        {
            return "" + NameOfBuyer + " - " + CellNumber;
        }
    }
}
