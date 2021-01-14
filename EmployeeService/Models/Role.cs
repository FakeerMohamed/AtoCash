using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string RoleCode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string RoleName { get; set; }

        [Required]
        public decimal MaxPettyCashAllowed { get; set; }

    }
}
