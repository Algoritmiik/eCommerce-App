using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Categories
    {
        [Key]
        public int categoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string categoryName { get; set; }
        public ICollection<SubCategories> subCategories { get; set; }
    }
}