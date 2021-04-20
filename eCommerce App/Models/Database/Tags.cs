using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Tags
    {
        [Key]
        public int tagId { get; set; }
        [Required]
        [StringLength(100)]
        public string tag { get; set; }
        [Required]
        public Products productId { get; set; }
    }
}