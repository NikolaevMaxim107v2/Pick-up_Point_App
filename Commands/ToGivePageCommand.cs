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
    public class ToGivePageCommand : CommandBase
    {
        private readonly NavigationStore navigationStore;
        public ICommand NavigateToAddPageCommand { get; }

        public ToGivePageCommand(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserDataStore userStore)
        {
            this.navigationStore = navigationStore;
            NavigateToAddPageCommand = new NavigationCommand<GivePageVM>(navigationStore, () => new GivePageVM(navigationStore, windowTitleStore, userStore));
        }

        public override void Execute(object parameter)
        {
            NavigateToAddPageCommand.Execute(true);
        }
    }
}
