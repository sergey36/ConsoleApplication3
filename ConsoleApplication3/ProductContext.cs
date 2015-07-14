using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication3
{
    class ProductContext : DbContext
    {

        public ProductContext()
            : base("DefaultConnection")
        { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Arduino> Arduinos { get; set; }
        public DbSet<City> Cities{ get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Manufacturer> Manufactureries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductDetailType> ProductsDetailTypes { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreManufacturerRef> StoreManufacturerRefs { get; set; }
    }
}


