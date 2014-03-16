using ShoeMartBusiness.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeMartBusiness.Services
{
    public class AccountService : IAccountService
    {
        private ILoggerService loggerService;

        public AccountService(ILoggerService loggerService) 
        {
            this.loggerService = loggerService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateUser(string userName, string password) 
        {
            bool validated = true;

            try
            {
                loggerService.Log(userName +":"+ password);//testing
            }
            catch (Exception e) 
            {
                loggerService.Log(e.ToString());
            }

            return validated;
        }
    }
}
