namespace ApplicationCore.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentName { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingMethod { get; set; }
        public decimal BillAmount { get; set; }
        public int OrderStatusId { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}

