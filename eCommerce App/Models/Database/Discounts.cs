using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Discounts
    {
        [Key]
        public int discountId { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        public float discount { get; set; }
        [Required]
        public int discountType { get; set; }
        [Required]
        public DateTime created { get; set; }
        [Required]
        public DateTime valid { get; set; }
        public int? quantity { get; set; }
        public ICollection<Orders> orders { get; set; }
    }
}