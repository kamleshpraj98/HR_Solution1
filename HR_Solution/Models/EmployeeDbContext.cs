using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Solution.Models
{
    public class EmployeeDbContext:DbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<User> Users { get; set; }
    }
}
