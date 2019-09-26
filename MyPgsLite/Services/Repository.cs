using MyPgsLite.Models;
using MyPgsLite.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPgsLite.Services
{
    public class Repository : IRepository
    {
        private List<Employee> employees;

        public Repository()
        {
            employees = new List<Employee>();
        }
        
        public void AddEmployee(Employee employee)
        {
            int id = 0;
            if (employees.Count > 0)
            {
                id = employees[0].Id;

                for (int i = 1; i < employees.Count; i++)
                {
                    if (id < employees[i].Id)
                    {
                        id = employees[i].Id;
                    }
                }
            }

            id++;
            employee.Id = id;

            employees.Add(employee);
        }

        public IEnumerable<Employee> ListEmployees()
        {
            return employees;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
    }
}
