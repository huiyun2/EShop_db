namespace ApplicationCore.Entities
{
    public class PromotionDetails
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }

        public virtual PromotionSale PromotionSale { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
