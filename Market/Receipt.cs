using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class Receipt
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int No { get; set; }
        public List<ReceiptProduct> ReceiptProducts { get; set; }
    }
}
