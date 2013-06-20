using System;
using System.Windows.Forms;
using Autosaloon.Exceptions;

namespace Autosaloon.Classes
{
    [Serializable]
    public class UIApplicationsForDelayedDelivery : Applications
    {
        public int SalePercent { get; set; }


        public UIApplicationsForDelayedDelivery(string nameOfBuyers,Car car,int percent)
            : base(nameOfBuyers,car)
        {
            SalePercent = percent;
        }

        public override int СalculateCost()
        {
            try
            {
                if(Car.QuantityInStock == 0)throw new CarNumberException("Машина отсутствует на складе");
                return (Car.Cost * (100 - SalePercent)) / 100;
            }
            catch (CarNumberException ex)
            {
                MessageBox.Show("" + ex);
                throw;
            }
        }

        public override string ToString()
        {
            return "" + NameOfBuyer + " - " + CellNumber + ";  "+SalePercent+"%";
        }
    }
}
