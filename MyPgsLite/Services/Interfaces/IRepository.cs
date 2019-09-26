using MyPgsLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPgsLite.Services.Interfaces
{
    public interface IRepository
    {
        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        IEnumerable<Employee> ListEmployees();
    }
}
