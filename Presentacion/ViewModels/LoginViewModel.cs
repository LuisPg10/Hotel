using System.Security;
using System.Windows;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _userName;
        private SecureString _password;

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
        public SecureString Password { 
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
        //Comandos
        public ICommand LoginCommand { get; }
        public ICommand ShowRegisterCommand { get; }

        //Constructor
        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            if (string.IsNullOrEmpty(UserName) || Password == null)
            {
                return false;
            }
            return true;
        }
        private void ExecuteLoginCommand(object obj)
        {
            MessageBox.Show("Hola");
        }
    }
}
