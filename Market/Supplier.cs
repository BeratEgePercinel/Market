using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TaxNo { get; set; }
        public string TelNumber { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
