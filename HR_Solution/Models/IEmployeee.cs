using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Solution.Models
{
    interface IEmployeee
    {
        public Employee GetAllEmployee();
        public Employee GetEmployee(int id);
        public Employee Add();
        public Employee Detele(int id);
        public Employee Update();

    }
}
