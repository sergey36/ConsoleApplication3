using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Arduino
    {
        public Arduino()
        {
            this.histories = new HashSet<History>();
            this.ApplicationUsers = new HashSet<ApplicationUser>();
        }
        int MacAddress;
        int ArduinoID;
        string UserID;

        public virtual ICollection<History> histories { get; set; }
      public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
}

}
