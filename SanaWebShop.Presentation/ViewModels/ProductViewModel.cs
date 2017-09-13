using System.ComponentModel.DataAnnotations;

namespace SanaWebShop.Presentation.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public string Name { get; set; }

        [Display(Name = "Product Number")]
        [Required]
        public string ProductNumber { get; set; }

        [Required]
        public float Price { get; set; }
    }
}