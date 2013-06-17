using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosaloon
{
    public class Avtosaloon
    {
        public string Name { get; set; }

        public Avtosaloon(string name)
        {
            Name = name;
        }
        private ArrayList Cars= new ArrayList();


    }
}
