using CoffeeShop.Data;
using CoffeeShop.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Models.Services
{
	public class ShoppingCartRepository : IShoppingCartRepository
	{
		private CoffeeShopDbContext dbContext;

		public ShoppingCartRepository(CoffeeShopDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public List<ShoppingCartItem>? ShoppingCartItems { get; set; }
		public string? ShoppingCartId { get; set; }

		public static ShoppingCartRepository GetCart(IServiceProvider services)
		{
			// dependency injection to access the session to the IServiceProvider
			ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

			// getting access to dbcontext
			CoffeeShopDbContext context = services.GetService<CoffeeShopDbContext>() ?? throw new Exception("Error initializing CoffeeShopDbContext.");

			// based on session, check if there is already a value called card ID for the incoming user
			// checking if user already has a card ID stored for the session and if not, create new unique ID
			string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

			// store the valud of the card ID in the session
			session?.SetString("CartId", cartId);

			// passing in dbcontext and shopping cart ID
			return new ShoppingCartRepository(context) { ShoppingCartId = cartId };
		}

		public void AddToCart(Product product)
		{
			var shoppingCartItem = dbContext.ShoppingCartItems.FirstOrDefault(s => s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);
			if(shoppingCartItem == null)
			{
				shoppingCartItem = new ShoppingCartItem
				{
					ShoppingCartId = ShoppingCartId, 
					Product = product, 
					Qty = 1
				};
				dbContext.ShoppingCartItems.Add(shoppingCartItem);
			}
			else
			{
				shoppingCartItem.Qty++;
			}
			dbContext.SaveChanges();
		}

		public void ClearCart()
		{
			var cartItems = dbContext.ShoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId);
			dbContext.ShoppingCartItems.RemoveRange(cartItems);
			dbContext.SaveChanges();
		}

		public List<ShoppingCartItem> GetShoppingCartItems()
		{
			return ShoppingCartItems ??= dbContext.ShoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId).Include(p => p.Product).ToList();
		}

		public decimal GetShoppingCartTotal()
		{
			var totalCost = dbContext.ShoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId).Select(s => s.Product.Price * s.Qty).Sum();
			return totalCost;
		}

		public int RemoveFromCart(Product product)
		{
			var shoppingCartItem = dbContext.ShoppingCartItems.FirstOrDefault(s => s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);
			var quantity = 0; 

			if(shoppingCartItem != null)
			{
				if(shoppingCartItem.Qty > 1)
				{
					shoppingCartItem.Qty--;
					quantity = shoppingCartItem.Qty;
				}
				else
				{
					dbContext.ShoppingCartItems.Remove(shoppingCartItem);
				}
			}
			dbContext.SaveChanges();
			return quantity;
		}
	}
}
