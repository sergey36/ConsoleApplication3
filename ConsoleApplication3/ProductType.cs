using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ConsoleApplication3
{
    class ProductType
    {
        [Key]
        [ForeignKey("Product")]
        int ProductTypeId;
        string ProductType1;
        public virtual Product Product { get; set; }

    }
}

