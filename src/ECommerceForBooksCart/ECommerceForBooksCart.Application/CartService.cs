namespace ECommerceForBooksCart.Application
{
    public class CartService : ICartService
    {
        public CartService() { }

        public void AddItemToCart(int itemId, int cartId)
        {
            //Implementation of adding the item to a cartId;
        }
    }

    public interface ICartService
    {
    }
}
