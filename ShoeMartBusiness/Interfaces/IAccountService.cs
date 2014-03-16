using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeMartBusiness.Interfaces
{
    public interface IAccountService
    {
        bool ValidateUser(string userName, string password);
    }
}
