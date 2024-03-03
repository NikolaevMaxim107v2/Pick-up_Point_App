using Pick_up_Point_App.Model;
using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.Stores;
using Pick_up_Point_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Pick_up_Point_App.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly LoginPageVM _viewModel;
        private readonly NavigationStore _navigationStore;
        public UserListStore _userListStore = new UserListStore();
        public UserStore _user = new UserStore();

        public string denied_symbols = "?#<>%@/";
        public bool _isUser = false;
        public bool _isAdmin = false;


        public ICommand NavigateToMainPageCommand { get; }
        public ICommand NavigateToMainPageAdminCommand { get; }
        public LoginCommand(LoginPageVM viewModel, NavigationStore navigationStore, WindowTitleStore windowTitleStore)
        {
            _viewModel = viewModel;
            _navigationStore = navigationStore;
            NavigateToMainPageCommand = new NavigationCommand<MainPageVM>(navigationStore, () => new MainPageVM(navigationStore,windowTitleStore, _user));
            NavigateToMainPageAdminCommand = new NavigationCommand<MainPageAdminVM>(navigationStore, () => new MainPageAdminVM(navigationStore, windowTitleStore, _user));
        }

        public void IsUser(string _login, string _password, List<User> _users)
        {
            _isUser = false;
            for (int i = 0; i < _users.Count; i++)
            {
                if (((_users[i].Login == _login) || (_users[i].Email == _login)) && (_users[i].Password == _password))
                {
                    _isUser = true;
                    _user.CurrentUser = _users[i];
                    break;
                }
            }
        }

        public override void Execute(object parameter)
        {
            if (_viewModel.LoginText != null)
            {
                if (_viewModel.PasswordText != null)
                {
                    if (_viewModel.PasswordText.Contains('?') || _viewModel.PasswordText.Contains('#') || _viewModel.PasswordText.Contains('<') || _viewModel.PasswordText.Contains('>') || _viewModel.PasswordText.Contains('%')
                        || _viewModel.PasswordText.Contains('@') || _viewModel.PasswordText.Contains('/'))
                    {
                        ErrorBox.DeniedSymbolsError();
                    }
                    else
                    {
                        IsUser(_viewModel.LoginText, _viewModel.PasswordText, _userListStore.UsersList);
                        if (_isUser == true)
                        {
                            if (_user.CurrentUser.IsAdmin)
                            {
                                MessageBox.Show($"Добро пожаловать! Для перехода далее нажмите 'ОК'", "Добро пожаловать!", MessageBoxButton.OK, MessageBoxImage.Information);
                                NavigateToMainPageAdminCommand.Execute(true);
                            }
                            else
                            {
                                MessageBox.Show($"Добро пожаловать! Для перехода далее нажмите 'ОК'", "Добро пожаловать!", MessageBoxButton.OK, MessageBoxImage.Information);
                                NavigateToMainPageCommand.Execute(true);
                            }
                            
                        }
                        else
                        {
                            ErrorBox.LoginPasswordError();
                        }
                    }
                }
                else { ErrorBox.EmptyPasswordError(); }
            }
            else { ErrorBox.EmptyLoginError(); }

        }
    }
}
