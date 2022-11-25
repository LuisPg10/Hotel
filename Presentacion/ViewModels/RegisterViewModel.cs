using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class RegisterViewModel: ViewModelBase
    {
        MainViewModel _mainViewModel;
        private string _correo;
        private string _usuario;
        private string _password;

        public string Correo
        {
            get
            {
                return _correo;
            }
            set
            {
                _correo = value;
                OnPropertyChange(nameof(Correo));
            }
        }

        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
                OnPropertyChange(nameof(Usuario));
            }
        }

        public string Password
        {
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

        public ICommand ShowLoginCommand { get; }
        public ICommand ShowSuccessFullCommand { get; }
        public RegisterViewModel(MainViewModel mainViewModel)
        {
            ShowLoginCommand = new RelayCommand(ExecuteShowLoginCommand);
            ShowSuccessFullCommand = new RelayCommand(ExeCuteShowSuccessFullCommand);
            _mainViewModel = mainViewModel;
        }

        private void ExecuteShowLoginCommand(object obj)
        {
            LoginViewModel loginViewModel = new LoginViewModel(_mainViewModel);
            Login login = new Login();
            login.DataContext = loginViewModel;
            _mainViewModel.SetNewContent(login);
        }

        private void ExeCuteShowSuccessFullCommand(object obj)
        {

        }
    }
}
