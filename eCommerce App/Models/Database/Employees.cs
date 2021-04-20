using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eCommerce_App.Models.Database
{
    public class Employees
    {
        [Key]
        public int employeeId { get; set; }
        [Required]
        public Shops shopId { get; set; }
        [Required]
        [StringLength(50)]
        public string firstName { get; set; }
        [Required]
        [StringLength(50)]
        public string lastName { get; set; }
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string email { get; set; }
        [Required]
        [StringLength(100)]
        public string passwordHash { get; set; }
        [Required]
        public DateTime hireDate { get; set; }
        public DateTime eliminateDate { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        [StringLength(100)]
        public string Position { get; set; }
        [Required]
        public int administration { get; set; }
    }
}