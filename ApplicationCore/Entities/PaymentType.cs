namespace ApplicationCore.Entities
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}

