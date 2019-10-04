using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class ProductExtension
    {
        public static DTO.Products toDTO(this Models.Products p)
        {
            return new DTO.Products
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            };
        }

        public static Models.Products ToDatabaseModel(this DTO.Products p)
        {
            return new Models.Products
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            };
        }
    }
}
