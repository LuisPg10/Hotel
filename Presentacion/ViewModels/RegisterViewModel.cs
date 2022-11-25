using Entidades;
using Logica;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class RegisterViewModel: ViewModelBase
    {
        uint cont = 0;
        MainViewModel _mainViewModel;
        ServicioUsuario _servicioUsuario;
        MessageBox mensaje;

        private string _correo = "Correo";
        private string _userName = "Nombre de usuario";
        private string _password = "Contraseña";

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
            if ((_userName.Equals("Usuario") || _password.Equals("Contraseña")) || _correo.Equals("Correo")
                || string.IsNullOrEmpty(_userName) || string.IsNullOrEmpty(_password) || string.IsNullOrEmpty(_correo))
            {
                mensaje = new MessageBox("Campos vacíos, rellene los campos necesarios");
            }
            else if (_servicioUsuario.VerificarUsuario(_userName))
            {
                mensaje = new MessageBox("Ya existe un usuario con ese nombre");
            }
            else
            {
                cont++;
                Usuario user = new Usuario(cont, _userName,_correo, _userName, _password);
                _servicioUsuario.RegistrarUsuario(user);
                mensaje = new MessageBox("Registro exitoso");
            }
            mensaje.ShowDialog();
        }
    }
}
