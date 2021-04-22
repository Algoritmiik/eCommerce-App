using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class CartItems
    {
        [Key]
        public int cartItemId { get; set; }
        [Required]
        public Users user { get; set; }
        [Required]
        public ProductDetails productDetail  { get; set; }
        [Required]
        public bool bought { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public DateTime timeAdded { get; set; }
    }
}