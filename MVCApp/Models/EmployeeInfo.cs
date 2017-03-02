using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeInfo
    {
        [Key]
        [Required]
        public int EmpNo { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public string DeptName { get; set; }
       [Required]
        public string Designation { get; set; }
        [Required]
        public decimal Salary { get; set; }
        
    }
}