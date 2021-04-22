using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class ProductDetails
    {
        [Key]
        public int productDetailId { get; set; }
        [Required]
        public Products productId { get; set; }
        public int? quantity { get; set; }
        [StringLength(15)]
        public string size { get; set; }
        [StringLength(50)]
        public string color { get; set; }
        public ICollection<CartItems> cartItem { get; set; }
        public ICollection<OrderItems> orderItem { get; set; }
    }
}