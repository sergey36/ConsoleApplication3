using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ConsoleApplication3
{
    class ProductDetailType
    {
        [Key]
        [ForeignKey("ProductDetail")]
        int ID;
        string valueType;
        string name;

        public virtual ProductDetail ProductDetail{ get; set; }
    }
}
