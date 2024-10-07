using ECommerceForBooksCatalog.Domain;

namespace ECommerceForBooksCatalog.Application
{
    public class BookFactory(ISpreadService spreadService)
    {
        private readonly ISpreadService spreadService = spreadService;

        public Book CreateBook(string title, string description, int authorId, decimal price, DateTime spreadDate)
        {
            var spreadValue = spreadService.GetSpreadValue(spreadDate);
            var bookPrice = price + (price * spreadValue);
            var book = new Book(title, description, authorId, bookPrice);
            return book;
        }
    }
}
