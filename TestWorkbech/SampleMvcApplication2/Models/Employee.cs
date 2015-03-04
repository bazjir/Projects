using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcApplication2.Models
{
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