using Pick_up_Point_App.Commands;
using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pick_up_Point_App.ViewModel
{
    public class LoginPageVM : PropertyChange
    {
        private string _loginText;
        private string _passwordText;

        public string LoginText { get => _loginText;  set { _loginText = value; OnPropertyChanged(nameof(LoginText)); OnPropertyChanged(nameof(IsLoginHintVisible)); } }
        public string PasswordText { get => _passwordText; set { _passwordText = value; OnPropertyChanged(nameof(PasswordText)); OnPropertyChanged(nameof(IsPasswordHintVisible)); } }

        public ICommand LoginCommand { get; }

        public string IsLoginHintVisible
        {
            get
            {
                if ((LoginText != null) && (LoginText != ""))
                {
                    return "Hidden";
                }
                else
                    return "Visible";
            }
        }

        public string IsPasswordHintVisible
        {
            get
            {
                if ((PasswordText != null) && (PasswordText != ""))
                {
                    return "Hidden";
                }
                else
                    return "Visible";
            }
        }

        public LoginPageVM(NavigationStore navigationStore, WindowTitleStore windowTitleStore)
        {
            windowTitleStore.WindowTitle = "Pick-up Point application: Authorization";
            LoginCommand = new LoginCommand(this, navigationStore, windowTitleStore);
        }
    }
}
