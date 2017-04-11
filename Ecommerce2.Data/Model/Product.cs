using System.ComponentModel.DataAnnotations;
namespace Ecommerce2.Data.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitInStock { get; set; }
        public decimal Price { get; set; }
        public int Vat { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}