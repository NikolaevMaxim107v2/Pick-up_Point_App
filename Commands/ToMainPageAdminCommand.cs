using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.Stores;
using Pick_up_Point_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pick_up_Point_App.Commands
{
    public class ToMainPageAdminCommand : CommandBase
    {
        private readonly NavigationStore navigationStore;
        public ICommand NavigateToMainPageCommand { get; }

        public ToMainPageAdminCommand(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserDataStore userStore)
        {
            this.navigationStore = navigationStore;
            NavigateToMainPageCommand = new NavigationCommand<MainPageAdminVM>(navigationStore, () => new MainPageAdminVM(navigationStore, windowTitleStore, userStore));
        }

        public override void Execute(object parameter)
        {
            NavigateToMainPageCommand.Execute(true);
        }
    }
}
