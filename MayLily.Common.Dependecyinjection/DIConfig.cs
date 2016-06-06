
using Autofac;

namespace MayLily.Common.Dependecyinjection
{
    public class DIConfig
    {
        public  void Config()
        {
            
            var builder = new ContainerBuilder();
            //./builder.RegisterType<MainLogon>.As<LoginView>();
            // builder.RegisterType<MainLogon>.As<Abstractions.Views.Windows.LoginView>();
        }
    }
}
