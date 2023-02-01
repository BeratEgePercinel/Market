using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class Sell
    {
        public int ID { get; set; }
        public Receipt Recepit { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
    }
}
