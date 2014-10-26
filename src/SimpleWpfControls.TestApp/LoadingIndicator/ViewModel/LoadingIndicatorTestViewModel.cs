using System.Windows.Input;
using SimpleWpfControls.TestApp.Helpers;
using SimpleWpfControls.TestApp.ViewModels;

namespace SimpleWpfControls.TestApp.LoadingIndicator.ViewModel
{
    class LoadingIndicatorTestViewModel : BaseVM
    {

        #region prop

      
        #region IsLoading

        private bool _isLoading;

        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                if (value == _isLoading)
                    return;
                _isLoading = value;
                OnPropertyChanged();
            }
        }

        #endregion IsLoading



        #endregion prop

        #region Command

        #region SimulateLoadingCommand

        private ICommand _simulateLoading;

        public ICommand SimulateLoadingCommand
        {
            get
            {
                return _simulateLoading
                       ?? (_simulateLoading = new RelayCommand(SimulateLoading));
            }
        }

        private void SimulateLoading()
        {
            IsLoading = !_isLoading;
        }

        #endregion SimulateLoadingCommand

        #endregion Command
    }
}
