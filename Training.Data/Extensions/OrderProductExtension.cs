using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class OrderProductExtension
    {
        public static DTO.OrderProduct ToDTO(this Models.OrderProduct op)
        {
            return new DTO.OrderProduct
            {
                OrderID = op.Id,
                ProductID = op.ProductId,
                Quantity = op.Quantity,
            };
        }

        public static Models.OrderProduct ToDatabaseModel(this DTO.OrderProduct op)
        {
            return new Models.OrderProduct
            {
                Id = op.OrderID,
                ProductId = op.ProductID,
                Quantity = op.Quantity,
            };

        }
    }
}
