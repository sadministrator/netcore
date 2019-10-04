using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Models
{
    public class Orders
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        List<OrderProduct> OrderProduct { get; set; }
    }
}
