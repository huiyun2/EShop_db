namespace ApplicationCore.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public string ProductImage { get; set; }
        public string SKU { get; set; }

        public ProductCategoryModel ProductCategory { get; set; }
        public ICollection<ProductVariationValueModel> ProductVariationValues { get; set; }
    }
}
