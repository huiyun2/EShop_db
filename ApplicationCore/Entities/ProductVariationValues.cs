namespace ApplicationCore.Entities
{
    public class ProductVariationValue
    {
        public int ProductId { get; set; }
        public int VariationValueId { get; set; }

        public virtual Product Product { get; set; }
        public virtual VariationValue VariationValue { get; set; }
    }
}
