using System.Windows;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        MainViewModel _mainViewModel;
        private string _userName;
        private string _password;

        //Propiedades
        public string UserName { 
            get
            {
                return _userName;
            } 
            set
            {
                _userName = value;
                OnPropertyChange(nameof(UserName));
            }  
        }
        public string Password { 
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChange(nameof(Password));
            } 
        }

        //Commands
        public ICommand ShowRegisterCommand { get; }
        public ICommand ShowPersonViewModel { get; }

        //Constructor
        public LoginViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;

            //Commands instance
            ShowRegisterCommand = new RelayCommand(ExeCuteRegisterCommand);
            ShowPersonViewModel = new RelayCommand(ExecutePersonViewCommand);
        }

        private void ExeCuteRegisterCommand(object obj)
        {
            RegisterViewModel registerViewModel = new RegisterViewModel(_mainViewModel);
            Register register = new Register();
            register.DataContext = registerViewModel;
            _mainViewModel.SetNewContent(register);
        }

        private void ExecutePersonViewCommand(object obj)
        {

        }
    }
}
