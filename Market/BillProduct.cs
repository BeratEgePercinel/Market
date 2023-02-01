using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class BillProduct
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int BillID { get; set; }
        public Bill Bill { get; set; }
        public int ID { get; set; }
    }
}
