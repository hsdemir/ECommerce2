using Ecommerce2.Data.Model;
using Ecommerce2.Data.Dto;
using System.Collections.Generic;

namespace Ecommerce2.Core.Repository
{
    public interface IProductRepository : IRepository<Product, ProductDto>
    {
        ICollection<ProductDto> GetByCategory(int categoryId);
    }
}
