
using System;
using System.Collections.ObjectModel;

namespace SimpleWpfControls.LoadingIndicator
{
    /// <summary>
    /// Interaction logic for LoadingIndicator.xaml
    /// </summary>
    public partial class LoadingIndicator
    {
        public ObservableCollection<PointAnimation> Points { get; private set; } 

        public LoadingIndicator()
        {
            Points = new ObservableCollection<PointAnimation>();
            for (var i = 0; i < 5; i++)
            {
                Points.Add(new PointAnimation()
                {
                    BeginTime = TimeSpan.FromMilliseconds(100 * i)
                });
            }

            InitializeComponent();
        }
    }
}
