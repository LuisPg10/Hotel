using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class PersonViewModel: ViewModelBase
    {
        MainViewModel _mainViewModel;
        
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
        public ICommand ShowRoomCommand { get; }
        public PersonViewModel() { }
        public PersonViewModel(MainViewModel mainViewModel, string namePerson) { 

            _mainViewModel = mainViewModel;

            this.namePerson = namePerson;
            message = $" Bienvenido {namePerson} ";

            
            ShowLoginViewCommand = new RelayCommand(ExecuteShowLoginViewCommand);
            ShowRoomCommand = new RelayCommand(ExecuteShowRoomCommand);
        }
        private void ExecuteShowLoginViewCommand(object obj)
        {
            Login login = new Login();
            LoginViewModel loginViewModel = new LoginViewModel(_mainViewModel);
            login.DataContext = loginViewModel;
            _mainViewModel.SetNewContent(login);
        }
        private void ExecuteShowRoomCommand(object obj)
        {

            if (Message.Equals($" Bienvenido {namePerson} "))
            {
                Message = " Habitación ";
                TextBtn = "←";
            }
            else
            {
                Message = $" Bienvenido {namePerson} ";
                TextBtn = "Habitacion reservada";
            }

        }
    }
}
