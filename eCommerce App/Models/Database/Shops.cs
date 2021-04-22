using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Shops
    {
        [Key]
        public int shopId { get; set; }
        [Required]
        [StringLength(100)]
        public string shopName { get; set; }
        [Required]
        [StringLength(300)]
        public string shopAddress { get; set; }
        public int? productTypeCounter { get; set; }
        public int? productCounter { get; set; }
        [StringLength(100)]
        public string shopPhotoUrl { get; set; }
        public ICollection<Products> products { get; set; }
        public ICollection<Employees> employees { get; set; }
    }
}