using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class Orders
    {
        public string Id { get; set; }
        public string UserID { get; set; }
        public string Status { get; set; }
        public DateTime Created_at { get; set; }
        public IList<OrderProduct> OrderProducts { get; set; }
    }
}
