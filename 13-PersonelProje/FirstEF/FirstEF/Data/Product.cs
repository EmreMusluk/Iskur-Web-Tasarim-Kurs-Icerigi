using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstEF.Data
{
    public class Product 
    {
        //Primary Key
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        //Category'i foreign key yapabilmek için yaptık ve ForeignKey üstüne yazmamız gerekir.
    }
}
