using Mart_Models;
using System.ComponentModel.DataAnnotations;

namespace MartWeb_Client.ViewModels
{
    public class DetailsVM
    {
        public DetailsVM()
        {
            ProductPrice = new();
            Count = 1;
        }

        [Range(1, int.MaxValue, ErrorMessage ="Value must be greater than 0")]
        public int Count { get; set; }
        [Required]
        public int SelectedProductPriceId { get; set; }
        public ProductPriceDTO ProductPrice { get; set; }
    }
}
