using SimpleWpfControls.TestApp.LoadingIndicator.ViewModel;

namespace SimpleWpfControls.TestApp.ViewModels
{
    class MainViewModel : BaseVM
    {
        private readonly LoadingIndicatorTestViewModel _loadingIndicatorTestViewModel;

        public MainViewModel(LoadingIndicatorTestViewModel loadingIndicatorTestViewModel)
        {
            _loadingIndicatorTestViewModel = loadingIndicatorTestViewModel;
        }

        #region prop
        public LoadingIndicatorTestViewModel LoadingIndicatorTestViewModel
        {
            get
            {
                return _loadingIndicatorTestViewModel;
            }
        }
        #endregion

    }
}
