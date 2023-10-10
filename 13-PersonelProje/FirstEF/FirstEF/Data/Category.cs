using System.ComponentModel.DataAnnotations;

namespace FirstEF.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
