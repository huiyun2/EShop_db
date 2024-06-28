namespace ApplicationCore.Models
{
    public class CategoryVariationModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string VariationName { get; set; }

        public ProductCategoryModel ProductCategory { get; set; }
        public ICollection<VariationValueModel> VariationValues { get; set; }
    }
}
