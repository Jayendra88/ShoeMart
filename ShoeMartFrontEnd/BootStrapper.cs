using Castle.Windsor;
using ShoeMartBusiness.Interfaces;
using ShoeMartBusiness.Services;
using ShoeMartFrontEnd.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeMartFrontEnd
{
    public static class BootStrapper 
    {
        //ILoggerService loggerService = null;
        //IAccountService accountService = null;

        //public string FileName { get; set; }

        //public ILoggerService GetLoggerService() 
        //{
        //    ILoggerService loggerService = new LoggerService();
        //    return loggerService;
        //}

        //public void WriteLogUsingConstructorInjection(string message)
        //{
        //    loggerService = new LoggerService(FileName);
        //    accountService = new AccountService();

        //    //MainWindow mWindow = new MainWindow(accountService, loggerService);
            
        //}
        public static IWindsorContainer container = null;
        public static void Initialise()
        {
            container = new WindsorContainer();

            container.AddComponent("LoggerService", typeof(ILoggerService), typeof(LoggerService));
            container.AddComponent("AccountService", typeof(IAccountService), typeof(AccountService));
            container.AddComponent("MainWindowViewModel", typeof(MainWindowViewModel));//LoginWindowViewModel
            container.AddComponent("LoginWindowViewModel", typeof(LoginWindowViewModel));
            //container.AddComponent("LoginWindow", typeof(LoginWindow));
            container.AddComponent("MainWindow", typeof(MainWindow));

            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            //MainWindow loginWindow = container.Resolve<LoginWindow>();
            MainWindow MainWindow = container.Resolve<MainWindow>();
            MainWindow.Show();
        }

        
    }
}
