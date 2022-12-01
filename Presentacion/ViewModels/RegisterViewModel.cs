using Entidades;
using Logica;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        MainViewModel _mainViewModel;
        LoginViewModel loginViewModel;
        Login login = new Login();

        MessageBox mensaje;

        private string _correo;
        private string _nombre;
        private string _userName;
        private string _password;
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
            _mainViewModel = mainViewModel;
            mensaje = new MessageBox();

            ShowLoginCommand = new RelayCommand(ExecuteShowLoginCommand);
            ShowSuccessFullCommand = new RelayCommand(ExeCuteShowSuccessFullCommand);
        }
        public RegisterViewModel() { }

        private void ExecuteShowLoginCommand(object obj)
        {
            if (loginViewModel == null)
            {
                loginViewModel = new LoginViewModel(_mainViewModel);
            }
            
            login.DataContext = loginViewModel;
            _mainViewModel.SetNewContent(login);
        }
        private void ExeCuteShowSuccessFullCommand(object obj)
        {
            if (string.IsNullOrEmpty(_userName) ||
                string.IsNullOrEmpty(_password) || string.IsNullOrEmpty(_correo))
            {
                ErrorMessage = "Campos vacíos, rellene los campos necesarios";
            }
            else if (MainViewModel._servicioUsuario.VerificarUsuario(_userName)
                || MainViewModel._servicioUsuario.verificarCorreo(_correo))
            {
                ErrorMessage = "Usuario o correo ya registrado";
            }
            else
            {
                Usuario user = new Usuario(_nombre, _correo, _userName, _password, null);
                MainViewModel._servicioUsuario.RegistrarUsuario(user);

                ErrorMessage = string.Empty;
                mensaje.Text("Registro exitoso");
                mensaje.ShowDialog();
                ExecuteShowLoginCommand(obj);
            }
        }
    }
}