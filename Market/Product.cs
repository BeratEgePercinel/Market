using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class Product
    {
        public int ID { get; set; }
        public int Barcode { get; set; }
        public string Name { get; set; }
        public int Brand { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
        public int TotalPrice { get; set; }
        public List<BillProduct> BillProducts  { get; set; }
        public List<ReceiptProduct> ReceiptProducts { get; set; }
    }
}
