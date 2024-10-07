namespace ECommerceForBooksCart.Domain
{
    public class Cart
    {
        public int Id { get; set; }
        public List<int> BooksId { get; set; } = new List<int>();

        public DateTime Checkout {  get; set; }
    }
}
