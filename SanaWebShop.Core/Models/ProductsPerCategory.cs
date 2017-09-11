using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanaWebShop.Core.Models
{
    public class ProductsPerCategory
    {
        [Key, Column(Order = 0)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Key, Column(Order = 1)]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
