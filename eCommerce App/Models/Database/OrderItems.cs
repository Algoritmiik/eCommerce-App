using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class OrderItems
    {
        [Key]
        public int orderItemId { get; set; }
        [Required]
        public Orders orderId { get; set; }
        [Required]
        public ProductDetails productDetailId { get; set; }
        [Required]
        public int quantity { get; set; }
    }
}