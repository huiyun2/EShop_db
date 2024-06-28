namespace ApplicationCore.Models
{
    public class OrderModel
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

        public PaymentMethodModel PaymentMethod { get; set; }
        public OrderStatusModel OrderStatus { get; set; }
        public ICollection<OrderDetailsModel> OrderDetails { get; set; }
    }
}
