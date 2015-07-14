using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Manufacturer
    {
        int ManufacturerId;
        string ManufacturerName;
        string Address;
        string PhoneNumber;
        int CityId;
        string EmailAddress;

        public virtual Product Product { get; set; }
        public virtual City City { get; set; }
        public virtual StoreManufacturerRef StoreManufacturerRef { get; set; }

    }
}
