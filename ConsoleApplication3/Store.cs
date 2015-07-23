using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ConsoleApplication3
{
    class Store
    {
        [Key]
        [ForeignKey("City")]
        int StoreID;
        string StoreName;
        string adress;
        string PhoneNumber;
        int CityID;

        public virtual City City { get; set; }


    }
}
