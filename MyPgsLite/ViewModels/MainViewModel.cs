using MyPgsLite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPgsLite.ViewModels
{
    public class MainViewModel
    {
        private readonly DataInputService dataInputService;
        private readonly UserManager userManager;

        private void ListUsers()
        {
            userManager.ListUsers();
        }

        private void AddUser()
        {
            userManager.AddUser();
        }

        private int GetUserDecision()
        {
            Console.WriteLine("Witaj w MyPGS Lite!");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Dodaj pracownika");
            Console.WriteLine("2. Listuj pracowników");
            Console.WriteLine("3. Wyjdź");

            int decision;
            do
            {
                decision = dataInputService.GetInt("Wybierz: ");

                if (decision < 1 || decision > 3)
                {
                    Console.WriteLine("Weź się ogarnij!");
                }
            }
            while (decision < 1 || decision > 3);

            return decision;
        }

        public MainViewModel(DataInputService dataInputService, UserManager userManager)
        {
            this.dataInputService = dataInputService;
            this.userManager = userManager;
        }

        public void Run()
        {
            int decision;

            do
            {
                decision = GetUserDecision();

                switch (decision)
                {
                    case 1:
                        {
                            AddUser();
                            break;
                        }
                    case 2:
                        {
                            ListUsers();
                            break;
                        }
                    case 3:
                        {
                            // Exit application
                            break;
                        }
                    default:
                        {
                            throw new InvalidOperationException("Unsupported choice");
                        }
                }
            }
            while (decision != 3);
        }
    }
}
