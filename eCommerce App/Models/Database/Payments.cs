using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Payments
    {
        [Key]
        public int paymentId { get; set; }
        public CreditCards creditCardId { get; set; }
        [StringLength(30)]
        public string paymentMethod { get; set; }
        [Required]
        public bool allowed { get; set; }
        [Required]
        public Orders order { get; set; }
    }
}