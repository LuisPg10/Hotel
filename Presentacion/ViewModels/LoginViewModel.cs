using Logica;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        MainViewModel _mainViewModel;
        ServicioUsuario _servicioUsuario;
        MessageBox mensaje;

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
            _servicioUsuario = new ServicioUsuario();

            //Commands instance
            ShowRegisterCommand = new RelayCommand(ExeCuteRegisterCommand);
            ShowPersonViewModel = new RelayCommand(ExecutePersonViewCommand);
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

            if ((_userName.Equals("Usuario") || _password.Equals("Contraseña")) ||
                string.IsNullOrEmpty(_userName) || string.IsNullOrEmpty(_password))
            {
                mensaje = new MessageBox("Campos vacíos, rellene los campos necesarios");
                mensaje.ShowDialog();
            }
            else if (!_servicioUsuario.VerificarEntradaUsuario(_userName, _password))
            {
                mensaje = new MessageBox("UserName o contraseña incorrecta");
                mensaje.ShowDialog();
            }
            else
            {
                PersonViewModel personViewModel = new PersonViewModel(_mainViewModel, UserName);
                PWindow user = new PWindow();
                user.DataContext = personViewModel;
                _mainViewModel.SetNewContent(user);
            }
        }
    }
}
