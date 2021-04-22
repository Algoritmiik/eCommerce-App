using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Orders
    {
        [Key]
        public int orderId { get; set; }
        [Required]
        public Users userId { get; set; }
        [Required]
        public UserAddresses address { get; set; }
        public Discounts discount { get; set; }
        [Required]
        public DateTime ordered { get; set; }
        public DateTime? modified { get; set; }
        [Required]
        [StringLength(30)]
        public string status { get; set; }
        [Required]
        public int amount { get; set; }
        [Required]
        public ICollection<OrderItems> orderItems { get; set; }
        public Payments payment { get; set; }
    }
}