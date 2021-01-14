using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.Models
{
    public class EmployementType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string EmptTypeCode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string EmptTypeDesc { get; set; }

    }
}
