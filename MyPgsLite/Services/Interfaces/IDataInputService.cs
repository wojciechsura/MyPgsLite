using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPgsLite.Services.Interfaces
{
    public interface IDataInputService
    {
        int GetInt(string message);
        string GetName(string message);
        decimal GetSalary(string message);
    }
}
