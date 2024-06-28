namespace ApplicationCore.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string ProfilePic { get; set; }
        public int UserId { get; set; }

        public ICollection<AddressModel> Addresses { get; set; }
        public ICollection<ShoppingCartModel> ShoppingCarts { get; set; }
    }
}
