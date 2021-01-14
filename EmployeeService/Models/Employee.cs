using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string MiddleName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public int EmpCode { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Position { get; set; }
        [Required]
        public int CostCentreID { get; set; }
        [Required]
        public int EmpRoleID { get; set; }
        public int GeoLocationID { get; set; }

        [Required]
        public int ReportingManagerID { get; set; }
        [Required]
        public int BankAccount { get; set; }
        public int BankCardNo { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string NationalID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string PassportNo { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string TaxNumber { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Nationality { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public DateTime DOJ { get; set; }
        public string Gender { get; set; }
        public int EmployementTypeID { get; set; }

        [Column(TypeName = "nvarchar(50)")]

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Mobile { get; set; }

        [Required]
        public int DepartmentID { get; set; }
        [Required]
        public int RptMgrRoleID { get; set; }
        //[Required]
        //public int ProjectID { get; set; }

        //public int WBSID { get; set; }

        //public int NetworkID { get; set; }

        //[Column(TypeName = "nvarchar(50)")]
        //public string Activity { get; set; }
    }
}
