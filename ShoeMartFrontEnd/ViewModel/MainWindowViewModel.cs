using ShoeMartBusiness.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeMartFrontEnd.ViewModel
{
    public class MainWindowViewModel
    {
        private IAccountService accountService;
        public MainWindowViewModel(IAccountService accountService) 
        {
            this.accountService = accountService;

            //LogIn();//testing
        }

        public void LogIn()
        {
            bool b = accountService.ValidateUser("Jayendra","Test123");
        }

    }
}
