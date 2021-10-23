using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Solution.Models
{
    
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Photopath { get; set; }
        public Department DepartmentId { get; set; }
    }
}
