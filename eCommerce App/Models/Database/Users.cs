using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace eCommerce_App.Models.Database
{
    public class Users
    {
        [Key]
        public int userId { get; set; }
        [StringLength(15)]
        [Required]
        [Index(IsUnique = true)]
        public string userName { get; set; }
        [StringLength(50)]
        [Required]
        public string firstName { get; set; }
        [StringLength(50)]
        [Required]
        public string lastName { get; set; }
        [StringLength(30)]
        [Required]
        [Index(IsUnique = true)]
        public string phoneNumber { get; set; }
        [StringLength(50)]
        [Required]
        [Index(IsUnique = true)]
        public string email { get; set; }
        [StringLength(100)]
        [Required]
        public string passwordHash { get; set; }
        [Required]
        public DateTime registeredAt { get; set; }
        public DateTime? modified { get; set; }
        public DateTime? lastLogin { get; set; }
        public ICollection<UserAddresses> userAddresses { get; set; }
        public ICollection<CartItems> cartItems { get; set; }
        public ICollection<Orders> orders { get; set; }
        public ICollection<CreditCards> creditCards { get; set; }
        public ICollection<Comments> comments { get; set; }
        public ICollection<Ratings> ratings { get; set; }
    }
}