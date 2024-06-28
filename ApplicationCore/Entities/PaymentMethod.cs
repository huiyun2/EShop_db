namespace ApplicationCore.Entities
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public int PaymentTypeId { get; set; }
        public string Provider { get; set; }
        public string AccountNumber { get; set; }
        public DateTime Expiry { get; set; }
        public bool IsDefault { get; set; }
        public int CustomerId { get; set; }

        public virtual PaymentType PaymentType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

