using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosaloon
{
    public class UIApplicationsInStock : Applications
    {

        public UIApplicationsInStock(String nameOfBuyer)
            : base(nameOfBuyer)
        {
        }

        public override int СalculateCost()
        {
            return Car.Cost;
        }
    }
}
