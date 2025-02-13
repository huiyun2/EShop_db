namespace ApplicationCore.Models
{
    public class PromotionSaleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<PromotionDetailsModel> PromotionDetails { get; set; }
    }
}
