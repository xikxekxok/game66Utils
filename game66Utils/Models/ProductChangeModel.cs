namespace game66Utils.Models
{
    public class ProductChangeModel
    {
        public string IdProduct { get; set; }
        public ProductModel OldProduct { get; set; }
        public ProductModel NewProduct { get; set; }
    }
}