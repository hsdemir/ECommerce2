using System.Collections.Generic;
using Ecommerce2.Core.Repository;
using Ecommerce2.Data.Model;
using Ecommerce2.Data.Dto;
using Ecommerce2.Core.Conversion;
using Ecommerce2.Data.DataContext;
using System.Linq;
using System.Data.Entity.Migrations;

namespace Ecommerce2.Core.Transaction
{
    public class CategoryTransaction : ICategoryRepository
    {
        private readonly Ecommerce2Context _context = new Ecommerce2Context();
        public CategoryDto Get(int id)
        {
            Category c = _context.Categories.Find(id);
            return CategoryConversion.Convert(c);
        }

        public ICollection<CategoryDto> List()
        {
            List<Category> cList = _context.Categories.ToList();
            return CategoryConversion.ListConvert(cList);
        }

        public int Insert(CategoryDto dto)
        {
            Category c = CategoryConversion.EntityConvert(dto);
            _context.Categories.Add(c);

            return _context.SaveChanges();
        }

        public int Update(CategoryDto dto)
        {
            Category c = CategoryConversion.EntityConvert(dto);
            _context.Categories.AddOrUpdate(c);

            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            Category c = _context.Categories.Find(id);
            if (c != null)
            {
                _context.Categories.Remove(c);
                return _context.SaveChanges();
            }

            return -1;
        }
    }
}
