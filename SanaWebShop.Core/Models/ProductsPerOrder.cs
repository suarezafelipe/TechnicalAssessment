using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanaWebShop.Core.Models
{
    public class ProductsPerOrder
    {
        [Key, Column(Order = 0)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Key, Column(Order = 1)]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
