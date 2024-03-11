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
    public class ToStatPageCommand : CommandBase
    {
        private readonly NavigationStore navigationStore;
        public ICommand NavigateToStatPageCommand { get; }

        public ToStatPageCommand(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserDataStore userStore)
        {
            this.navigationStore = navigationStore;
            NavigateToStatPageCommand = new NavigationCommand<StatPageVM>(navigationStore, () => new StatPageVM(navigationStore, windowTitleStore, userStore));
        }

        public override void Execute(object parameter)
        {
            NavigateToStatPageCommand.Execute(true);
        }
    }
}
