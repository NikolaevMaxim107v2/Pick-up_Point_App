using Pick_up_Point_App.Stores;
using Pick_up_Point_App.Model.Base;
using Pick_up_Point_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pick_up_Point_App.Commands
{
    public class ToMainPageCommand : CommandBase
    {
        private readonly NavigationStore navigationStore;
        public ICommand NavigateToMainPageCommand { get; }

        public ToMainPageCommand(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserStore userStore)
        {
            this.navigationStore = navigationStore;
            NavigateToMainPageCommand = new NavigationCommand<MainPageVM>(navigationStore, () => new MainPageVM(navigationStore, windowTitleStore, userStore));
        }

        public override void Execute(object parameter)
        {
            NavigateToMainPageCommand.Execute(true);
        }
    }
}
