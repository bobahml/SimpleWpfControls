using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimpleWpfControls.TestApp.ViewModels
{
    public class BaseVM : INotifyPropertyChanged
    {

        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion INPC
    }
}
