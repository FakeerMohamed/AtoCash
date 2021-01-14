using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.Models
{
    public class Department
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string DeptCode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string DeptName { get; set; }

    }
}
