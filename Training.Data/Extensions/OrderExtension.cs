using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class OrderExtension
    {
        public static DTO.Orders ToDTO(this Models.Orders o)
        {
            return new DTO.Orders
            {
                Id = o.Id,
                UserID = o.UserId,
            };
        }

        public static Models.Orders ToDatabaseModel(this DTO.Orders o)
        {
            return new Models.Orders
            {
                Id = o.Id,
                UserId = o.UserID
            };
        }
    }
}
