using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Ratings
    {
        [Key]
        public int ratingId { get; set; }
        [Required]
        public Users userId { get; set; }
        [Required]
        public Products productId{ get; set; }
        public int ratingValue { get; set; }
        public DateTime modified { get; set; }
    }
}