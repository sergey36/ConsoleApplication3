using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ProductType
    {
        int ProductTypeId;
        string ProductType1;
        public virtual Product Product { get; set; }

    }
}

