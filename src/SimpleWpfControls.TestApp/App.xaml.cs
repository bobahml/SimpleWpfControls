using System;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using SimpleWpfControls.TestApp.ViewModels;
using SimpleWpfControls.TestApp.Views;

namespace SimpleWpfControls.TestApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs ea)
        {
            base.OnStartup(ea);

            AppDomain.CurrentDomain.UnhandledException += (s, e) => LogUnhandledException((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");
            DispatcherUnhandledException += (s, e) => LogUnhandledException(e.Exception, "Application.Current.DispatcherUnhandledException");
            TaskScheduler.UnobservedTaskException += (s, e) => LogUnhandledException(e.Exception, "TaskScheduler.UnobservedTaskException");



            MainWindow = new MainView { DataContext = Container.AutofacContainer.Resolve<MainViewModel>() };
            MainWindow.Show();
        }



        private static void LogUnhandledException(Exception exceptionObject, string source)
        {
            MessageBox.Show(
                string.Format("Необработанное исключение ({0}): {1}{2}", source, Environment.NewLine,
                exceptionObject));
        }
    }
}
