using Blazored.LocalStorage;
using Mart_Common;
using MartWeb_Client.Service.IService;
using MartWeb_Client.ViewModels;

namespace MartWeb_Client.Service
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        public CartService(ILocalStorageService localStorageService)
        {
            _localStorage = localStorageService;
        }
        public async Task DecrementCart(Cart cartToDecrement)
        {
            var shoppingCart = await _localStorage.GetItemAsync<List<Cart>>(SD.Cart);
            for(int i=0; i < shoppingCart.Count; i++)
            {
                if (shoppingCart[i].ProductId == cartToDecrement.ProductId && shoppingCart[i].ProductPriceId == cartToDecrement.ProductPriceId)
                {
                    if (shoppingCart[i].Count == 1 || shoppingCart[i].Count == 0)
                    {
                        shoppingCart.Remove(shoppingCart[i]);
                    }
                    else
                    {
                        shoppingCart[i].Count -= cartToDecrement.Count;
                    }
                }
            }
            await _localStorage.SetItemAsync(SD.Cart, shoppingCart);
        }
    

        public async Task IncrementCart(Cart cartToAdd)
        {
            var shoppingCart = await _localStorage.GetItemAsync<List<Cart>>(SD.Cart);
            bool itemInCart = false;

            if(shoppingCart == null)
            {
                shoppingCart = new List<Cart>();
            }
            foreach(var obj in shoppingCart)
            {
                if(obj.ProductId == cartToAdd.ProductId && obj.ProductPriceId == cartToAdd.ProductPriceId)
                {
                    itemInCart = true;
                    obj.Count += cartToAdd.Count;
                }
            }
            if (!itemInCart)
            {
                shoppingCart.Add(new Cart()
                {
                    ProductId = cartToAdd.ProductId,
                    ProductPriceId = cartToAdd.ProductPriceId,
                    Count = cartToAdd.Count
                });
            }
            await _localStorage.SetItemAsync(SD.Cart, shoppingCart);
        }
    }
}


