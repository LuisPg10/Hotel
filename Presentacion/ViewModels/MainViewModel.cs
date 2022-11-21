using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private ViewModelBase _currentChildView;

        //Propiedades
        public ViewModelBase CurrentChildView
        {   
            get 
            { 
                return _currentChildView; 
            }
            set
            {
                _currentChildView = value;
                OnPropertyChange(nameof(CurrentChildView));
            }
        }

        public ICommand ShowLoginCommand { get; }

        public MainViewModel()
        {
            //Initializate commands
            ShowLoginCommand = new ViewModelCommand(ExecuteShowLoginCommand);

            //Default view
            ExecuteShowLoginCommand(null);
        }
        private void ExecuteShowLoginCommand(object obj)
        {
            CurrentChildView = new LoginViewModel();
        }
    }
}
