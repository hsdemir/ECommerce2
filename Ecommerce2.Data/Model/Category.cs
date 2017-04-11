using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce2.Data.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Sort { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}