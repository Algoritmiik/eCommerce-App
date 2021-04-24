using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class SubCategories
    {
        [Key]
        public int subCategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string subCategoryName { get; set; }
        [Required]
        public Categories categoryId { get; set; }
        public ICollection<Products> products { get; set; }
    }
}