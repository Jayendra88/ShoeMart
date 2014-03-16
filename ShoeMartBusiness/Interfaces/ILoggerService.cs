using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeMartBusiness.Interfaces
{
    public interface ILoggerService
    {
        void OpenLog();
        void CloseLog();
        void Log(string message);
    }
}
