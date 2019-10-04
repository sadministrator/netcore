using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class OrderProduct
    {
        public string OrderID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }


        public Orders Orders { get; set; }

        public Products Products { get; set; }
    }
}
