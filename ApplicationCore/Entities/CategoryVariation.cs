namespace ApplicationCore.Entities
{
    public class CategoryVariation
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string VariationName { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<VariationValue> VariationValues { get; set; }
    }
}
