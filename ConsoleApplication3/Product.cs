using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Product
    {
         public Product()
        {
            this.Histories = new HashSet<History>();
            this.ProductDetails = new HashSet<ProductDetail>();
        }
    
     public     int  ProductId {get;set;}
     public   string ProductName {get;set;}
     public    int ManufacturerId {get;set;}
     public  int ProductTypeId {get;set;}

     public virtual History History { get; set; }
     public virtual ProductType ProductType { get; set; }
     public virtual ProductDetail ProductDetail { get; set; }
     public virtual Manufacturer Manufacturer { get; set; }
     public virtual ICollection<History> Histories { get; set; }
     public virtual ICollection<ProductDetail> ProductDetails { get; set; }

    }
}
