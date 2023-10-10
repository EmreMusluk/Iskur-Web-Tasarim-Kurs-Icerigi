using FirstEF.Data;

namespace FirstEF.Models
{
    public class ProductsModel
    {
        public Product Product { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public string cls { get; set; }
        public List<Category> Categories { get; set; }
    }
}
