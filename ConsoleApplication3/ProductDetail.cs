using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ProductDetail
    {
        int ID;
        string value;
        int ProductDetailTypeID;

        public virtual Product Product{ get; set; }
        public virtual ProductDetailType ProductDetailType { get; set; }
    }
}
