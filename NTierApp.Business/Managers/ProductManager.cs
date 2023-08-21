using NTierApp.Data.Repositories;
using NTierApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.Business.Managers
{
    // Product ile ilgili businesstan sorumlu
    public class ProductManager
    {
        private readonly ProductRepository productRepository;
        public ProductManager() {
         
            productRepository = new ProductRepository();
        }

        public List<ProductListDto> GetProducts()
        {
            var productDtoList = new List<ProductListDto>();


            var list =   productRepository.GetProducts();

            foreach (var product in list)
            {
                var productDto = new ProductListDto();
                productDto.Id = product.Id;
                productDto.Name = product.Name;
                productDto.Price = product.Price;

                productDtoList.Add(productDto);
                
            }

            return productDtoList;

        }

    }
}
