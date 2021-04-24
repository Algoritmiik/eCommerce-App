using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Products
    {
        [Key]
        public int productId { get; set; }
        [Required]
        public Shops shopId { get; set; }
        [Required]
        [StringLength(100)]
        public string productName { get; set; }
        [Required]
        public SubCategories subCategoryId { get; set; }
        [StringLength(100)]
        public string descriptions { get; set; }
        [Required]
        public int price { get; set; }
        public ICollection<ProductDetails> productDetails { get; set; }
        public ICollection<Tags> tags { get; set; }
        public ICollection<Comments> comments { get; set; }
        public ICollection<Ratings> ratings { get; set; }
    }
}
