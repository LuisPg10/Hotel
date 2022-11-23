using System.Windows.Controls;

namespace Presentacion.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private UserControl currentChildView;

        internal void SetNewContent(UserControl currentChildView)
        {
            CurrentChildView = currentChildView;
        }
        public UserControl CurrentChildView
        {
            get
            {
                return currentChildView;
            }
            set
            {
                currentChildView = value;
                OnPropertyChange(nameof(CurrentChildView));
            }
        }
        public MainViewModel(){}
    }
}
