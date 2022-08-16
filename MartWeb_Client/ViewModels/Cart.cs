using Mart_Models;

namespace MartWeb_Client.ViewModels
{
    public class Cart
    {
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public int ProductPriceId { get; set;}
        public ProductPriceDTO ProductPrice { get; set; }
        public int Count { get; set; }
    }
}
