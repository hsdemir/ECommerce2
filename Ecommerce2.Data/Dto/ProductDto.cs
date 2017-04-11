using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce2.Data.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public int UnitInStock { get; set; }
        public decimal Price { get; set; }
        public int Vat { get; set; }

        public CategoryDto Category { get; set; }
    }
}