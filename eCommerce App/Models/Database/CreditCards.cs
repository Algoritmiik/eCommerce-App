using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class CreditCards
    {
        [Key]
        public int creditCardId { get; set; }
        [Required]
        public Users userId { get; set; }
        [Required]
        [StringLength(50)]
        public string creditCardName { get; set; }
        [Required]
        [StringLength(100)]
        public string holderName { get; set; }
        [StringLength(16)]
        [Required]
        [Index(IsUnique = true)]
        public string cardNumber { get; set; }
        [Required]
        public DateTime expireDate { get; set; }
        [StringLength(3)]
        [Required]
        public string CVV { get; set; }
        public ICollection<Payments> payments { get; set; }
    }
}