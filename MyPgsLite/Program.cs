using MyPgsLite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPgsLite
{
    class Program
    {
        static void Main(string[] args)
        {
            DataInputService inputService = new DataInputService();

            string test = inputService.GetName("Podaj imię");
            decimal salary = inputService.GetSalary("Podaj wynagrodzenie");
        }
    }
}
