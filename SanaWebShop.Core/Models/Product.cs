using System.ComponentModel.DataAnnotations;

namespace SanaWebShop.Core.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductNumber { get; set; }

        public string Title { get; set; }

        public float Price { get; set; }
    }
}
