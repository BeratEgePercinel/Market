using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class ReceiptProduct
    {
        public int ID { get; set; }
        public int ReceiptID { get; set; }
        public Receipt Receipt { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
