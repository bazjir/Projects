using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcApplication.Models
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Delicious Treat")]
        [Required(ErrorMessage = "The product name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The product description field is required.")]
        public string Description { get; set; }

        [DisplayName("Sale Price")]
        [Required(ErrorMessage = "The Sale Price field is required.")]
        public decimal Price { get; set; }

        [DisplayName("Freshly Baked on")]
        [Required(ErrorMessage = "The Freshly Baked On field is required.")]
        public DateTime CreationDate { get; set; }

        [DisplayName("Don't Sell After")]
        [Required(ErrorMessage = "The Expiration Date field is required.")]
        public DateTime ExpirationDate { get; set; }

        [DisplayName("Qty Available")]
        [Required(ErrorMessage = "The Qty Available field is required.")]
        [Range(0, 120)]
        public int QtyOnHand { get; set; }

        [DisplayName("Product Image")]
        public string ImageName { get; set; }
    }

    [Bind(Exclude = "EmpId")]
    public class Employee
    {
        [ScaffoldColumn(false)]
        public int EmpId { get; set; }

        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(100, MinimumLength = 3)]
        public String EmpName { get; set; }

        [Required(ErrorMessage = "Employee Address is required")]
        [StringLength(300)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(3000, 10000000, ErrorMessage = "Salary must be between 3000 and 10000000")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
    }
}