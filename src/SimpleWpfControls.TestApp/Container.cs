using System.Reflection;
using Autofac;
using SimpleWpfControls.TestApp.ViewModels;

namespace SimpleWpfControls.TestApp
{
    internal class Container
    {       
        private static readonly IContainer _container;
        static Container()
        {
            _container = RegisterDependencies();
        }



        public static IContainer AutofacContainer
        {
            get { return _container; }
        }

        public static MainViewModel GetMainViewModel()
        {
            return _container.Resolve<MainViewModel>();
        }


        private static IContainer RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetCallingAssembly())
                .Where(type => type.Name.EndsWith("ViewModel"))
                .AsSelf()
                .InstancePerDependency();

            // Build the container.
            return builder.Build();
        }

    }
}
