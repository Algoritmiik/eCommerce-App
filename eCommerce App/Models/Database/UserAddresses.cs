using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class UserAddresses
    {
        [Key]
        public int addressId { get; set; }
        [Required]
        public Users user { get; set; }
        [Required]
        [StringLength(100)]
        public string addressName { get; set; }
        [Required]
        [StringLength(100)]
        public string address1 { get; set; }
        [StringLength(100)]
        public string address2 { get; set; }
        [Required]
        [StringLength(10)]
        public string postCode { get; set; }
        [Required]
        [StringLength(100)]
        public string city { get; set; }
        [Required]
        [StringLength(30)]
        public string phone { get; set; }
        public ICollection<Orders> orders{ get; set; }
    }
}