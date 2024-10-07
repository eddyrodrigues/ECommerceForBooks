namespace ECommerceForBooksCatalog.Domain
{
    public class Book
    {
        public int Id { get; set; } = 1;
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; }
        public decimal Price { get; set; }
        public Book() { }

        public Book(string title, string description, int authorId, decimal price)
        {
            Title = title;
            Description = description;
            AuthorId = authorId;
            Price = price;
        }
    }
}
