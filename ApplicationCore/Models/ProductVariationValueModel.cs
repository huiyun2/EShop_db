namespace ApplicationCore.Models
{
    public class ProductVariationValueModel
    {
        public int ProductId { get; set; }
        public int VariationValueId { get; set; }

        public ProductModel Product { get; set; }
        public VariationValueModel VariationValue { get; set; }
    }
}
