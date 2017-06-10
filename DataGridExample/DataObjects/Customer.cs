using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CustID { get; set; }
        public Orders CustomerOrders { get; set; }
    }
}
