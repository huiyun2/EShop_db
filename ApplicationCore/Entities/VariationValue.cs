namespace ApplicationCore.Entities
{
    public class VariationValue
    {
        public int Id { get; set; }
        public int VariationId { get; set; }
        public string Value { get; set; }

        public virtual CategoryVariation CategoryVariation { get; set; }
        public virtual ICollection<ProductVariationValue> ProductVariationValues { get; set; }
    }
}
