using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace SimpleWpfControls.LoadingIndicator
{
    /// <summary>
    /// Interaction logic for LoadingIndicator.xaml
    /// </summary>
    public partial class LoadingIndicator
    {
        public LoadingIndicator()
        {

            Visibility = IsLoading ? Visibility.Visible : Visibility.Collapsed;
            InitializeComponent();
                        var myBinding = new Binding {Source = Points};
                        PointsControl.SetBinding(ItemsControl.ItemsSourceProperty, myBinding);
        }

        #region Dp
        #region IsLoading

        public static readonly DependencyProperty IsLoadingProperty = DependencyProperty.Register(
            "IsLoading", typeof(bool), typeof(LoadingIndicator), new PropertyMetadata(OnIsloadingChangedCallback));


        private static void OnIsloadingChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            var loadIndicator = (LoadingIndicator)d;

            var nv = args.NewValue as bool?;
            if (nv == null || !nv.Value)
            {
                loadIndicator.Points.Clear();
                loadIndicator.Visibility = Visibility.Collapsed;
            }

            else
            {
                loadIndicator.ReinitPoints();
                loadIndicator.Visibility = Visibility.Visible;
            }

        }

        public bool IsLoading
        {
            get { return (bool)GetValue(IsLoadingProperty); }
            set { SetValue(IsLoadingProperty, value); }
        }

        #endregion IsLoading

        #endregion

        #region prop
        #region Points
        private readonly ObservableCollection<PointAnimation> _points = new ObservableCollection<PointAnimation>();
        private ObservableCollection<PointAnimation> Points
        {
            get { return _points; }
        }
        #endregion Points

        #endregion prop

        #region private

        private void ReinitPoints()
        {
            for (var i = 0; i < 6; i++)
            {
                Points.Add(new PointAnimation
                {
                    BeginTime = TimeSpan.FromMilliseconds(100 * i),
                    StartAngle = -i * 10,
                    StopAngle = 360 - i * 10
                });
            }
        }
        #endregion private

    }
}
