using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class PersonViewModel: ViewModelBase
    {
        MainViewModel _mainViewModel;
        private string namePerson = " Bienvenido User  ";

        public string NamePerson
        {
            get
            {
                return namePerson;
            }
            set
            {
                namePerson = value;
                OnPropertyChange(nameof(NamePerson));
            }
        }

        public ICommand ShowLoginViewCommand { get; }
        public PersonViewModel() { }
        public PersonViewModel(MainViewModel mainViewModel, string namePerson) { 
            _mainViewModel = mainViewModel;
            NamePerson = $"Bienvenido {namePerson}  ";

            ShowLoginViewCommand = new RelayCommand(ExecuteShowLoginViewCommand);
        }

        private void ExecuteShowLoginViewCommand(object obj)
        {
            Login login = new Login();
            LoginViewModel loginViewModel = new LoginViewModel(_mainViewModel);
            login.DataContext = loginViewModel;
            _mainViewModel.SetNewContent(login);
        }
    }
}
