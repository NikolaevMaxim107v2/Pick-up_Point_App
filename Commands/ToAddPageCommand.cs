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
    public class ToAddPageCommand : CommandBase
    {
        private readonly NavigationStore navigationStore;
        public ICommand NavigateToAddPageCommand { get; }

        public ToAddPageCommand(NavigationStore navigationStore, WindowTitleStore windowTitleStore, UserStore userStore)
        {
            this.navigationStore = navigationStore;
            NavigateToAddPageCommand = new NavigationCommand<AddPageVM>(navigationStore, () => new AddPageVM(navigationStore, windowTitleStore, userStore));
        }

        public override void Execute(object parameter)
        {
            NavigateToAddPageCommand.Execute(true);
        }
    }
}
