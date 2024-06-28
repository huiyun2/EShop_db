namespace ApplicationCore.Models
{
    public class ProductCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }

        public ProductCategoryModel ParentCategory { get; set; }
        public ICollection<ProductCategoryModel> SubCategories { get; set; }
        public ICollection<CategoryVariationModel> CategoryVariations { get; set; }
    }
}
