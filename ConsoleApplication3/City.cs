using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class City
    {
        int ID;
        string name;

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Store Store{ get; set; }
    }
}
