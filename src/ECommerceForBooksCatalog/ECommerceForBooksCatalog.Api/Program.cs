using ECommerceForBooksCatalog.Application;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

// Busca Catálogo : Mostra livros do Catálogo
app.MapGet("/books", (IBookService bookService) =>
{
    return bookService.GetBooks();
});

// Verifica estoque
app.MapGet("/books/{id}/in-stock", (IBookService bookService, [FromRoute] int id) =>
{
    return bookService.HasItemInStock(id);
});

app.Run();
