using System.Windows;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        MainViewModel _mainViewModel;
        private string _userName = "Usuario";
        private string _password = "Contraseña";

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
            ShowPersonViewModel = new RelayCommand(ExecutePersonViewCommand, CanExecutePersonViewCommand);
        }
        public LoginViewModel(){}

        private void ExeCuteRegisterCommand(object obj)
        {
            RegisterViewModel registerViewModel = new RegisterViewModel(_mainViewModel);
            Register register = new Register();
            register.DataContext = registerViewModel;
            _mainViewModel.SetNewContent(register);
        }

        private void ExecutePersonViewCommand(object obj)
        {
            PersonViewModel personViewModel = new PersonViewModel(_mainViewModel, UserName);
            PWindow user = new PWindow();
            user.DataContext = personViewModel;
            _mainViewModel.SetNewContent(user);
        }

        private bool CanExecutePersonViewCommand(object obj)
        {
            return true;
        }
    }
}
