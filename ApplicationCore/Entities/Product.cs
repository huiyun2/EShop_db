namespace ApplicationCore.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public string ProductImage { get; set; }
        public string SKU { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProductVariationValue> ProductVariationValues { get; set; }
    }
}