using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce2.Data.Model;
using Ecommerce2.Data.Dto;

namespace Ecommerce2.Core.Conversion
{
    public static class CategoryConversion
    {
        public static CategoryDto Convert(Category c)
        {
            CategoryDto dto = new CategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                IsActive = c.IsActive,
                Sort = c.Sort
            };

            return dto;
        }

        public static ICollection<CategoryDto> ListConvert(List<Category> cList)
        {
            List<CategoryDto> dtoList = new List<CategoryDto>();
            foreach (Category c in cList)
            {
                CategoryDto dto = new CategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    IsActive = c.IsActive,
                    Sort = c.Sort
                };

                dtoList.Add(dto);
            }

            return dtoList;
        }

        public static Category EntityConvert(CategoryDto dto)
        {
            Category c = new Category
            {
                Id = dto.Id,
                Name = dto.Name,
                IsActive = dto.IsActive,
                Sort = dto.Sort
            };

            return c;
        }
    }
}
