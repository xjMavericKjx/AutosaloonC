﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosaloon
{
    public abstract class Application
    {
        public string NameOfBuyer { get; set; }
        public string CellNumber { get; set; }
        public Car Car { get; set; }

        public abstract int СalculateCost();

    }



}