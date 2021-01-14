using EmployeeService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Data
{
    public class EmployeeDbContext:DbContext
    {

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
           
        }

        public  DbSet<Employee> employees { get; set; }
        public DbSet<EmployementType> employementTypes { get; set; }

        public DbSet<Role> roles{ get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<CostCentre> costCentres{ get; set; }

        //DbSet<GeoLocation> geoLocations{ get; set; }


    }
}
