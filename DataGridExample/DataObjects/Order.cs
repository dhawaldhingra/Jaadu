using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Order
    {
        public Product ProductDetails { get; set; }

        public int OrderID { get; set; }

        public int OrderQty { get; set; }

        public double PricePerUnit { get; set; }
    }
}
