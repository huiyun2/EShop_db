namespace ApplicationCore.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }
        public bool IsDefaultAddress { get; set; }

        public CustomerModel Customer { get; set; }
    }
}
