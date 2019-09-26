using MyPgsLite.Services;
using MyPgsLite.ViewModels;
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
            Repository repository = new Repository();
            DataInputService dataInputService = new DataInputService();
            UserManager userManager = new UserManager(repository, dataInputService);
            MainViewModel mainViewModel = new MainViewModel(dataInputService, userManager);
            
            mainViewModel.Run();
        }
    }
}
