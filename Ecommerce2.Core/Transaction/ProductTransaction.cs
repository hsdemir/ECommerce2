using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Ecommerce2.Core.Repository;
using Ecommerce2.Core.Conversion;
using Ecommerce2.Data.Model;
using Ecommerce2.Data.Dto;
using Ecommerce2.Data.DataContext;

namespace Ecommerce2.Core.Transaction
{
    public class ProductTransaction : IProductRepository
    {
        private readonly Ecommerce2Context _context = new Ecommerce2Context();
        public ICollection<ProductDto> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public ProductDto Get(int id)
        {
            Product c = _context.Products.Find(id);
            return ProductConversion.Convert(c);
        }

        public ICollection<ProductDto> List()
        {
            List<Product> cList = _context.Products.ToList();
            return ProductConversion.ListConvert(cList);
        }

        public int Insert(ProductDto dto)
        {
            Product c = ProductConversion.EntityConvert(dto);
            _context.Products.Add(c);

            return _context.SaveChanges();
        }

        public int Update(ProductDto dto)
        {
            Product c = ProductConversion.EntityConvert(dto);
            _context.Products.AddOrUpdate(c);

            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            Product c = _context.Products.Find(id);
            if (c != null)
            {
                _context.Products.Remove(c);
                return _context.SaveChanges();
            }

            return -1;
        }


    }
}
