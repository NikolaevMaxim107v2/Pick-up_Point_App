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
    public class ToUserDataCommand : CommandBase
    {
        private readonly NavigationStore navigationStore;
        public ICommand NavigateToUserDataCommand { get; }

        public ToUserDataCommand(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserDataStore userStore)
        {
            this.navigationStore = navigationStore;
            NavigateToUserDataCommand = new NavigationCommand<UserDataPageVM>(navigationStore, () => new UserDataPageVM(navigationStore, windowTitleStore, userStore));
        }

        public override void Execute(object parameter)
        { 
            NavigateToUserDataCommand.Execute(true);
        }
    }
}
