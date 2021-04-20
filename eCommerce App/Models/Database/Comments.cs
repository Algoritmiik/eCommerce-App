using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Comments
    {
        [Key]
        public int commentId { get; set; }
        [Required]
        public Users userId { get; set; }
        [Required]
        public Products productId{ get; set; }
        [StringLength(200)]
        public string comment { get; set; }
        public DateTime modified { get; set; }
    }
}