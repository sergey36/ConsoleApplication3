using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Store
    {
        int StoreID;
        string StoreName;
        string adress;
        string PhoneNumber;
        int CityID;

        public virtual City City { get; set; }


    }
}
