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
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = new MainView {DataContext = Container.AutofacContainer.Resolve<MainViewModel>()};
            MainWindow.Show();
        }
    }
}
