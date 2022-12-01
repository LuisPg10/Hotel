using Entidades;
using Logica;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        MainViewModel _mainViewModel;
        RegisterViewModel registerViewModel;
        Register register;

        PersonViewModel personViewModel;
        PWindow mainView;

        private string _userName;
        private string _password;
        private string _errorMessage;

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
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChange(nameof(ErrorMessage));
            }
        }
        //Commands
        public ICommand ShowRegisterCommand { get; }
        public ICommand ShowPersonViewModel { get; }

        //Constructor
        
        public LoginViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            register = new Register();

            //Commands instance
            ShowRegisterCommand = new RelayCommand(ExeCuteRegisterCommand);
            ShowPersonViewModel = new RelayCommand(ExecutePersonViewCommand);
        }
        public LoginViewModel(){}
        private void ExeCuteRegisterCommand(object obj)
        {
            if (registerViewModel == null)
            {
                registerViewModel = new RegisterViewModel(_mainViewModel);
            }
            register.DataContext = registerViewModel;
            _mainViewModel.SetNewContent(register);
        }
        private void ExecutePersonViewCommand(object obj)
        {

            if (string.IsNullOrEmpty(_userName) || string.IsNullOrEmpty(_password))
            {
                ErrorMessage = "Campos vacíos, rellene los campos necesarios";
            }
            else if (!MainViewModel._servicioUsuario.VerificarEntradaUsuario(_userName, _password))
            {
                ErrorMessage = "Usuario o contraseña incorrecta";
            }
            else
            {
                ErrorMessage = string.Empty;
                Usuario usuario = MainViewModel._servicioUsuario.ConsultarUsuario(UserName);

                if (personViewModel == null && mainView == null)
                {
                    personViewModel = new PersonViewModel(_mainViewModel, usuario.Nombre);
                    mainView = new PWindow(usuario);
                }
                mainView.DataContext = personViewModel;
                _mainViewModel.SetNewContent(mainView);
            }
        }
    }
}
