﻿using System.Windows.Forms;
using Autosaloon.Exceptions;

namespace Autosaloon
{
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
        public override string ToString()
        {
            return "" + NameOfBuyer + " - " + CellNumber;
        }

        public abstract int СalculateCost();
    }



}
