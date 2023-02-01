using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class Bill
    {
        public int ID { get; set; }
        public int Unit { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        public List<BillProduct> BillProducts { get; set; }
    }
}
