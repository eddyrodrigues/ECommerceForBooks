using ECommerceForBooksCatalog.Domain;

namespace ECommerceForBooksCatalog.Application;

public interface IBookService
{
    List<Book> GetBooks();
    bool HasItemInStock(int id);
}