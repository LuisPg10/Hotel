﻿using Entidades;
using Logica;
using System.Windows.Input;

namespace Presentacion.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        MainViewModel _mainViewModel;
        ServicioUsuario _servicioUsuario;

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

            if (string.IsNullOrEmpty(_userName) || string.IsNullOrEmpty(_password))
            {
                ErrorMessage = "Campos vacíos, rellene los campos necesarios";
            }
            else if (!_servicioUsuario.VerificarEntradaUsuario(_userName, _password))
            {
                ErrorMessage = "Usuario o contraseña incorrecta";
            }
            else
            {
                ErrorMessage = string.Empty;
                PersonViewModel personViewModel;
                Usuario usuario = _servicioUsuario.ConsultarUsuario(UserName);

                personViewModel = new PersonViewModel(_mainViewModel, usuario.Nombre);
                PWindow user = new PWindow(usuario);
                user.DataContext = personViewModel;
                _mainViewModel.SetNewContent(user);
            }
        }
    }
}
