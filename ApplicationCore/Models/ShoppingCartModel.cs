namespace ApplicationCore.Models
{
    public class ShoppingCartModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public CustomerModel Customer { get; set; }
        public ICollection<ShoppingCartItemModel> ShoppingCartItems { get; set; }
    }
}
