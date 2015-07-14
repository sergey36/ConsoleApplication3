using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ProductDetailType
    {
        int ID;
        string valueType;
        string name;

        public virtual ProductDetail ProductDetail{ get; set; }
    }
}
