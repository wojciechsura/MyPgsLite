using MyPgsLite.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyPgsLite.Services
{
    public class DataInputService : IDataInputService
    {
        public string GetName(string message)
        {
            Console.WriteLine(message);

            string result;
            bool valid;
            do
            {
                result = Console.ReadLine();
                valid = Regex.IsMatch(result, "^[A-Z][a-zA-Z]*$");

                if (!valid)
                {
                    Console.WriteLine("Nieprawidłowy ciąg, wpisz ponownie.");
                }
            }
            while (!valid);

            return result;
        }

        public decimal GetSalary(string message)
        {
            Console.WriteLine(message);

            string input;
            decimal result;
            bool valid;
            do
            {
                input = Console.ReadLine();
                valid = decimal.TryParse(input, out result);

                if (!valid)
                {
                    Console.WriteLine("Nieprawidłowy ciąg, wpisz ponownie.");
                }
            }
            while (!valid);

            return result;
        }

        public int GetInt(string message)
        {
            Console.WriteLine(message);

            string input;
            int result;
            bool valid;
            do
            {
                input = Console.ReadLine();
                valid = int.TryParse(input, out result);

                if (!valid)
                {
                    Console.WriteLine("Nieprawidłowy ciąg, wpisz ponownie.");
                }
            }
            while (!valid);

            return result;
        }
    }
}
