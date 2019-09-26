using MyPgsLite.Models;
using MyPgsLite.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPgsLite.Services
{
    public class UserManager : IUserManager
    {
        private readonly IRepository repository;
        private readonly IDataInputService dataInputService;

        public UserManager(IRepository repository, IDataInputService dataInputService)
        {
            this.repository = repository;
            this.dataInputService = dataInputService;
        }

        public void ListEmployee()
        {
            foreach (Employee employee in repository.ListEmployees())
            {
                Console.WriteLine($"{employee.Name} {employee.Surname} zarabia {employee.Salary} USD");
            }
        }

        public void AddEmployee()
        {
            Console.WriteLine("Dodajesz pracownika.");

            string name = dataInputService.GetName("Podaj imię: ");
            string surname = dataInputService.GetName("Podaj nazwisko: ");
            decimal salary = dataInputService.GetSalary("Podaj wynagrodzenie: ");

            Employee employee = new Employee()
            {
                Name = name,
                Surname = surname,
                Salary = salary
            };

            repository.AddEmployee(employee);
        }
    }
}
