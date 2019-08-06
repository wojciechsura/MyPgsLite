using MyPgsLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPgsLite.Services
{
    public class Repository
    {
        private List<Employee> employees;

        public Repository()
        {
            employees = new List<Employee>();
        }

        public List<Employee> Employees
        {
            get
            {
                return employees;
            }
        }
    }
}
