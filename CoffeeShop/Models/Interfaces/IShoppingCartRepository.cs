namespace CoffeeShop.Models.Interfaces
{
	public interface IShoppingCartRepository
	{
		void AddToCart(Product product);
		int RemoveFromCart(Product product);
		List<ShoppingCartItem> GetShoppingCartItems();
		int GetShoppingCartCount();

		void ClearCart();
		decimal GetShoppingCartTotal(); 
		public List<ShoppingCartItem>? ShoppingCartItems { get; set; }
	}
}
