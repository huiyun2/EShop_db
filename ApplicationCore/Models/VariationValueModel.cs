namespace ApplicationCore.Models
{
    public class VariationValueModel
    {
        public int Id { get; set; }
        public int VariationId { get; set; }
        public string Value { get; set; }

        public CategoryVariationModel CategoryVariation { get; set; }
        public ICollection<ProductVariationValueModel> ProductVariationValues { get; set; }
    }
}
