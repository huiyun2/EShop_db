namespace ApplicationCore.Models
{
    public class PaymentMethodModel
    {
        public int Id { get; set; }
        public int PaymentTypeId { get; set; }
        public string Provider { get; set; }
        public string AccountNumber { get; set; }
        public DateTime Expiry { get; set; }
        public bool IsDefault { get; set; }
        public int CustomerId { get; set; }

        public PaymentTypeModel PaymentType { get; set; }
    }
}
