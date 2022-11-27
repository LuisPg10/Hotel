using Entidades;
using Logica;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class RegisterViewModel: ViewModelBase
    {
        MainViewModel _mainViewModel;
        ServicioUsuario _servicioUsuario;
        MessageBox mensaje;

        private string _correo = "Correo";
        private string _nombre = "Nombre";
        private string _userName = "Usuario";
        private string _password = "Contraseña";
        private string _errorMessage;

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
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
                OnPropertyChange(nameof(Nombre));
            }
        }
        public string UserName
        {
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

        public ICommand ShowLoginCommand { get; }
        public ICommand ShowSuccessFullCommand { get; }

        public RegisterViewModel(MainViewModel mainViewModel)
        {
            _servicioUsuario = new ServicioUsuario();
            _mainViewModel = mainViewModel;

            ShowLoginCommand = new RelayCommand(ExecuteShowLoginCommand);
            ShowSuccessFullCommand = new RelayCommand(ExeCuteShowSuccessFullCommand);
        }
        public RegisterViewModel(){}
        private void ExecuteShowLoginCommand(object obj)
        {
            LoginViewModel loginViewModel = new LoginViewModel(_mainViewModel);
            Login login = new Login();
            login.DataContext = loginViewModel;
            _mainViewModel.SetNewContent(login);
        }
        private void ExeCuteShowSuccessFullCommand(object obj)
        {
            if ((_userName.Equals("Usuario") || _password.Equals("Contraseña")) || _correo.Equals("Correo") ||
                _nombre.Equals("Nombre") || string.IsNullOrEmpty(_userName) || 
                string.IsNullOrEmpty(_password) || string.IsNullOrEmpty(_correo))
            {
                ErrorMessage = "Campos vacíos, rellene los campos necesarios";
            }
            else if (_servicioUsuario.VerificarUsuario(_userName) || _servicioUsuario.verificarCorreo(_correo))
            {
                ErrorMessage = "Usuario o correo ya registrado";
            }
            else
            {
                Usuario user = new Usuario(_nombre, _correo, _userName, _password, null);
                _servicioUsuario.RegistrarUsuario(user);

                ErrorMessage = string.Empty;
                mensaje = new MessageBox("Registro exitoso");
                mensaje.ShowDialog();

                ExecuteShowLoginCommand(obj);
            }
        }
    }
}