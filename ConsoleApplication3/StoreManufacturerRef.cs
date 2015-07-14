using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StoreManufacturerRef
    {
         public StoreManufacturerRef()
        {
            this.Stores = new HashSet<Store>();
        }
        int ManufacturerID;
        int StoreID;
        public virtual ICollection<Store> Stores { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
