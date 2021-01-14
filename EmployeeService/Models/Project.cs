using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.Models
{
    public class Project
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string ProjectCode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string ProjectName { get; set; }
    }
}
