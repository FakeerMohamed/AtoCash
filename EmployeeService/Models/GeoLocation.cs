using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.Models
{
    public class GeoLocation
    {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Lattitude { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Longitude { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string State { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Country { get; set; }
    }
}
