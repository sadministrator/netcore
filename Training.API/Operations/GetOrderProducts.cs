using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;

namespace Training.API.Operations
{
    public class GetOrderProducts
    {
        private readonly IOrderProductRepository _OrdersProductsRepository;

        public GetOrderProducts(IOrderProductRepository orderProductRepository)
        {
            _OrdersProductsRepository = orderProductRepository;
        }

        public async Task<List<DTO.OrderProduct>> Execute()
        {
            return await _OrdersProductsRepository.GetAll();
        }
    }
}
