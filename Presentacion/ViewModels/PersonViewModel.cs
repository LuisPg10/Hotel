using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class PersonViewModel: ViewModelBase
    {
        MainViewModel _mainViewModel;
        LoginViewModel _loginViewModel;
        Login login;
        
        private string namePerson;
        private string message = $" Bienvenido user ";
        private string textBtn = "Habitacion reservada";

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                OnPropertyChange(nameof(Message));
            }
        }
        public string TextBtn
        {
            get
            {
                return textBtn;
            }
            set
            {
                textBtn = value;
                OnPropertyChange(nameof(TextBtn));
            }
        }
        
        public ICommand ShowLoginViewCommand { get; }
        public PersonViewModel() { }
        public PersonViewModel(MainViewModel mainViewModel, string namePerson) { 

            _mainViewModel = mainViewModel;

            login = new Login();

            this.namePerson = namePerson;
            message = $" Bienvenido {namePerson} ";

            ShowLoginViewCommand = new RelayCommand(ExecuteShowLoginViewCommand);
        }
        private void ExecuteShowLoginViewCommand(object obj)
        {
            _loginViewModel = new LoginViewModel(_mainViewModel);
            login.DataContext = _loginViewModel;
            _mainViewModel.SetNewContent(login);
        }
    }
}
