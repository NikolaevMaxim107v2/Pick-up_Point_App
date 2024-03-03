using Pick_up_Point_App.Commands;
using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.Stores;
using Pick_up_Point_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pick_up_Point_App.ViewModel
{
    public class WelcomePageVM : PropertyChange
    {
        public ICommand NavigateToLoginPageCommand { get; }

        public WelcomePageVM(NavigationStore navigationStore, WindowTitleStore windowTitleStore)
        {
            NavigateToLoginPageCommand = new NavigationCommand<LoginPageVM>(navigationStore, () => new LoginPageVM(navigationStore, windowTitleStore));//navigationStore, windowTitleStore));
            windowTitleStore.WindowTitle = "Welcome to Pick-up Point application!";
        }
    }
}
