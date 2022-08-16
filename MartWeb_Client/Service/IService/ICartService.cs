using MartWeb_Client.ViewModels;

namespace MartWeb_Client.Service.IService
{
    public interface ICartService
    {
        Task DecrementCart(Cart cart);
        Task IncrementCart(Cart cart);
    }
}
