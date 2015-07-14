using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication3
{
    class History
    {
        int HistoryID;
        int ProductID;
        DateTime AddedDate;
        DateTime ExpireDate;
        int ArduinoID;
        DateTime RemoveDate;
        public virtual Product Product { get; set; }
        public virtual Arduino Arduino { get; set; }
      

    }
}
