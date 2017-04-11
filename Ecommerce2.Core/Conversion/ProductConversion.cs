using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce2.Data.Model;
using Ecommerce2.Data.Dto;

namespace Ecommerce2.Core.Conversion
{

    public static class ProductConversion
    {
        public static ProductDto Convert(Product p)
        {
            ProductDto dto = new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                UnitInStock = p.UnitInStock,
                Price = p.Price,
                Vat = p.Vat,
                Category = CategoryConversion.Convert(p.Category)
            };

            return dto;
        }

        public static ICollection<ProductDto> ListConvert(List<Product> pList)
        {
            List<ProductDto> dtoList = new List<ProductDto>();
            foreach (Product p in pList)
            {
                ProductDto dto = new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    UnitInStock = p.UnitInStock,
                    Price = p.Price,
                    Vat = p.Vat,
                    Category = CategoryConversion.Convert(p.Category)
                };

                dtoList.Add(dto);
            }

            return dtoList;
        }

        public static Product EntityConvert(ProductDto dto)
        {
            Product p = new Product
            {
                Id = dto.Id,
                Name = dto.Name,
                UnitInStock = dto.UnitInStock,
                Price = dto.Price,
                Vat = dto.Vat,
                Category = CategoryConversion.EntityConvert(dto.Category)
            };

            return p;
        }
    }
}
