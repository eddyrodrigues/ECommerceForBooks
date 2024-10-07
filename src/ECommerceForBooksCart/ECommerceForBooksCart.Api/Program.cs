using ECommerceForBooksCart.Domain;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

app.MapPost("/cart/add-item/{itemId}", ([FromRoute] int itemId) =>
{
    var cart = new Cart();
    cart.BooksId.Add(itemId);
    return cart;
});

app.Run();
