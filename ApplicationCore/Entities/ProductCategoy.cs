namespace ApplicationCore.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }

        public virtual ProductCategory ParentCategory { get; set; }
        public virtual ICollection<ProductCategory> SubCategories { get; set; }
        public virtual ICollection<CategoryVariation> CategoryVariations { get; set; }
    }
}
