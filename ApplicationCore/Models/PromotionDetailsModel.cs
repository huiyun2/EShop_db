namespace ApplicationCore.Models
{
    public class PromotionDetailsModel
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }

        public PromotionSaleModel PromotionSale { get; set; }
        public ProductCategoryModel ProductCategory { get; set; }
    }
}
