using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce2.Data.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Sort { get; set; }
    }
}